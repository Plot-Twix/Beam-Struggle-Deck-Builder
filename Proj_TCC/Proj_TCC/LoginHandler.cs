using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_TCC
{
    internal static class LoginHandler
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
                using (StreamReader stream = new StreamReader("login_info.txt"))
                {
                    string text = stream.ReadToEnd(); // leitura das informações de login locais
                    if (text.Contains("id_usuario: -1"))
                    {
                        new Form_Login().ShowDialog();
                        return -1; // Indica que o usuário não está logado
                    }
                    // lógica para pegar o id do usuário logado e buscar suas informações no banco de dados
                    int startIndex = text.IndexOf("idUsuario: ") + 11;
                    int endIndex = text.IndexOf('\n', startIndex);
                    return int.Parse(text.Substring(startIndex, endIndex - startIndex));
                }
            }
            catch (FileNotFoundException)
            {
                new Form_Login().ShowDialog();
                return -1; // Indica que o arquivo de login não foi encontrado
            }
            catch (IOException)
            {

            }

            return 0; // Indica que não houve nenhum erro ao ler o arquivo de login
        }
        public static string GetLoginInfo(string info, string text) {
            int startIndex = text.IndexOf(info + ": ");
            int endIndex = text.IndexOf('\n', startIndex);

            return text.Substring(startIndex, endIndex - startIndex); // Indica que não houve nenhum erro ao ler o arquivo de login
        }
    }
}
