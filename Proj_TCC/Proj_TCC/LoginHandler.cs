using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MySql.Data.MySqlClient;

namespace Proj_TCC
{
    public static class LoginHandler
    {
        static LoginHandler()
        {
            // Static constructor to initialize any static data or perform actions that need to be done once
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
                
            }
            catch (FileNotFoundException)
            {
                CreateEmptyLogin(); // Cria um arquivo de login vazio
                return -1; // Indica que o arquivo de login não foi encontrado
            }
            catch (IOException)
            {
                //idealmente logar o erro aqui;
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
