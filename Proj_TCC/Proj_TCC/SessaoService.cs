using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Proj_TCC
{
    public class SessaoService
    {
        private readonly string connectionString =
            "Server=127.0.0.1;Database=tcc;Uid=root;Pwd=;";

        // Caminho do arquivo local onde o token criptografado é salvo
        private readonly string caminhoArquivoToken =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                         "TCC", "sessao.token");

        private const int DiasValidadeToken = 30;

        /// <summary>
        /// Gera um novo token, salva o hash no banco e o valor real
        /// criptografado (DPAPI) no disco local.
        /// Chame isso logo após um login bem-sucedido, se o usuário marcar "lembrar-me".
        /// </summary>
        public void CriarSessaoPersistente(int idUsuario)
        {

            if (idUsuario <= 0)
                throw new ArgumentException(
                    "idUsuario inválido. Certifique-se de passar o id retornado por um login bem-sucedido.",
                    nameof(idUsuario));

            // Gera token aleatório seguro
            byte[] tokenBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(tokenBytes);
            }
            string token = Convert.ToBase64String(tokenBytes);
            string tokenHash = BCrypt.Net.BCrypt.HashPassword(token);
            DateTime expiracao = DateTime.UtcNow.AddDays(DiasValidadeToken);

            // Salva o hash no banco
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string query = @"INSERT INTO sessao_token (id_usuario, token_hash, data_expiracao)
                                  VALUES (@idUsuario, @tokenHash, @expiracao)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@tokenHash", tokenHash);
                    cmd.Parameters.AddWithValue("@expiracao", expiracao);
                    cmd.ExecuteNonQuery();
                }
            }

            // Salva o token real, criptografado com DPAPI, no disco local
            SalvarTokenLocal(idUsuario, token);
        }

        /// <summary>
        /// Tenta restaurar a sessão a partir do token salvo localmente.
        /// Retorna o id do usuário autenticado, ou 0 se não houver sessão válida.
        /// </summary>
        public int RestaurarSessao()
        {
            if (!File.Exists(caminhoArquivoToken))
                return 0;

            (int idUsuario, string token) dadosLocais = LerTokenLocal();
            if (dadosLocais.idUsuario == 0 || string.IsNullOrEmpty(dadosLocais.token))
                return 0;

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string query = @"SELECT token_hash, data_expiracao FROM sessao_token
                                  WHERE id_usuario = @idUsuario
                                  ORDER BY data_expiracao DESC LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", dadosLocais.idUsuario);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            string tokenHash = leitor.GetString("token_hash");
                            DateTime expiracao = leitor.GetDateTime("data_expiracao");

                            if (expiracao < DateTime.UtcNow)
                            {
                                EncerrarSessaoPersistente(); // token expirado
                                return 0;
                            }

                            if (BCrypt.Net.BCrypt.Verify(dadosLocais.token, tokenHash))
                            {
                                return dadosLocais.idUsuario;
                            }
                        }
                    }
                }
            }

            return 0; // token inválido
        }

        /// <summary>
        /// Remove a sessão persistente (usar no botão "Sair" / logout).
        /// </summary>
        public void EncerrarSessaoPersistente()
        {
            if (File.Exists(caminhoArquivoToken))
                File.Delete(caminhoArquivoToken);
        }

        // ---- Métodos auxiliares (DPAPI) ----

        private void SalvarTokenLocal(int idUsuario, string token)
        {
            string conteudo = idUsuario + "|" + token;
            byte[] dados = Encoding.UTF8.GetBytes(conteudo);

            // CurrentUser: só o usuário do Windows logado consegue descriptografar
            byte[] dadosCriptografados = ProtectedData.Protect(
                dados, null, DataProtectionScope.CurrentUser);

            Directory.CreateDirectory(Path.GetDirectoryName(caminhoArquivoToken));
            File.WriteAllBytes(caminhoArquivoToken, dadosCriptografados);
        }

        private (int idUsuario, string token) LerTokenLocal()
        {
            try
            {
                byte[] dadosCriptografados = File.ReadAllBytes(caminhoArquivoToken);
                byte[] dados = ProtectedData.Unprotect(
                    dadosCriptografados, null, DataProtectionScope.CurrentUser);

                string conteudo = Encoding.UTF8.GetString(dados);
                string[] partes = conteudo.Split('|');

                if (partes.Length == 2 && int.TryParse(partes[0], out int idUsuario))
                    return (idUsuario, partes[1]);
            }
            catch
            {
                // arquivo corrompido, de outra máquina/usuário, etc.
                EncerrarSessaoPersistente();
            }

            return (0, null);
        }
    }
}
