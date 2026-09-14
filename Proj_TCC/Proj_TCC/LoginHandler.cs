using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipelines;
using System.Text;

namespace Proj_TCC
{
    public static class LoginHandler
    {
        public static int idUsuario = 0;
        private readonly static string connectionString = "Server=127.0.0.1;Database=tcc;Uid=root;Pwd=;";

        static LoginHandler()
        {
            // Static constructor to initialize any static data or perform actions that need to be done once
        }

        /// <summary>
        /// Cadastra um novo usuário na tabela `usuario`.
        /// Retorna true se o cadastro foi concluído com sucesso.
        /// </summary>
        public static bool CadastrarUsuario(string apelido, string email, string senha, out string mensagem)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    // Verifica se já existe um usuário com o mesmo e-mail
                    string queryVerifica = "SELECT COUNT(*) FROM usuario WHERE email = @email";
                    using (MySqlCommand cmdVerifica = new MySqlCommand(queryVerifica, conexao))
                    {
                        cmdVerifica.Parameters.AddWithValue("@email", email);
                        long quantidade = (long)cmdVerifica.ExecuteScalar();

                        if (quantidade > 0)
                        {
                            mensagem = "Já existe um usuário cadastrado com este e-mail.";
                            return false;
                        }
                    }

                    // Gera o hash da senha antes de armazenar (nunca salve senha em texto puro)
                    string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

                    string queryInsere =
                        "INSERT INTO usuario (apelido, email, senha) VALUES (@apelido, @email, @senha)";

                    using (MySqlCommand cmdInsere = new MySqlCommand(queryInsere, conexao))
                    {
                        cmdInsere.Parameters.AddWithValue("@apelido", apelido);
                        cmdInsere.Parameters.AddWithValue("@email", email);
                        cmdInsere.Parameters.AddWithValue("@senha", senhaHash);

                        cmdInsere.ExecuteNonQuery();
                    }

                    mensagem = "Usuário cadastrado com sucesso!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar usuário: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Valida as credenciais de login contra a tabela `usuario`.
        /// Retorna true se o login for válido e preenche o id do usuário autenticado.
        /// </summary>
        public static bool Login(string email, string senha, out int idUsuario, out string mensagem)
        {
            idUsuario = 0;

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    string query = "SELECT id, senha FROM usuario WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader leitor = cmd.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                string senhaHashArmazenada = leitor.GetString("senha");

                                if (BCrypt.Net.BCrypt.Verify(senha, senhaHashArmazenada))
                                {
                                    idUsuario = leitor.GetInt32("id");
                                    mensagem = "Login realizado com sucesso!";
                                    return true;
                                }
                                else
                                {
                                    mensagem = "Senha incorreta.";
                                    return false;
                                }
                            }
                            else
                            {
                                mensagem = "E-mail não encontrado.";
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao efetuar login: " + ex.Message;
                return false;
            }
        }

        public static int GetLoginStatus()
        {
            // Lógica para verificar se o usuário está logado
            try
            {
                string text;
                using (StreamReader stream = new StreamReader("login_info.txt"))
                {
                    text = stream.ReadToEnd(); // leitura das informações de login locais
                }
                if (text.Contains("id_usuario: -1"))
                {
                    new Form_Login().ShowDialog();
                    return -1; // Indica que o usuário não está logado
                }
                // lógica para pegar o id do usuário logado e buscar suas informações no banco de dados
                string userId = GetInfo("id_usuario", text);
                string getEmail = GetInfo("email_usuario", text);
                string senha = GetInfo("senha", text);

                // lógica para buscar as informações do usuário no banco de dados usando o userId

                /* Crítca postergada: validação de email e senha; Em estágios iniciais de desenvolvimento, as validações não serão consideradas,
                 * assumindo que o usuário irá inserir as informações corretamente.
                 
                MySqlDataReader reader;
                using (MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;senha=;database=tcc"))
                {
                    connection.Open();
                    // lógica para executar a consulta no banco de dados
                    MySqlCommand command = new MySqlCommand(
                        $"SELECT * FROM usuario WHERE email = '{getEmail}' AND senha = '{senha}'",
                        connection);
                    reader = command.ExecuteReader();
                }
                if (reader.HasRows)
                {
                    // O usuário está logado
                    return 0; // Indica que o usuário está logado
                }
                else
                {
                    new Form_Login().ShowDialog();
                    return -1; // Indica que o usuário não está logado
                }
                */
                
            }
            catch (FileNotFoundException)
            {
                CreateEmptyLogin(); // Cria um arquivo de login vazio
                return -1; // Indica que o arquivo de login não foi encontrado
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro ao ler o arquivo de login: " + ex.Message);
            }

            return 0; // Indica que não houve nenhum erro ao ler o arquivo de login
        }

        public static string GetInfo(string info, string text) {
            int startIndex = text.IndexOf(info + ": ");
            int endIndex = text.IndexOf('\n', startIndex);

            return text.Substring(startIndex, endIndex - startIndex); // Indica que não houve nenhum erro ao ler o arquivo de login
        }

        public static int CreateEmptyLogin() {
            // Lógica para criar um novo login
            using (StreamWriter writer = new StreamWriter("login_info.txt"))
            {
                writer.WriteLine("id_usuario: -1");
                writer.WriteLine("email_usuario: null");
                writer.WriteLine("senha: null");
            }
            return 0;
        }

        public static int CreateLogin(int id, string email, string senha)
        {
            // Lógica para criar um novo login localmente
            using (StreamWriter writer = new StreamWriter("login_info.txt"))
            {
                writer.WriteLine("id_usuario: " + id);
                writer.WriteLine("email_usuario: " + email);
                writer.WriteLine("senha: " + senha);
            }
            return 0;
        }
    }
}
