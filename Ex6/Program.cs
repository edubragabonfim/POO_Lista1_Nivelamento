//// 5) Crie um método public string[] VerificarEmail(string[] emails, string dominio).
//// Este método recebe um vetor de strings e o nome de um domínio como parâmetro.
//// Cada posição do vetor possui um endereço de e-mail, com nome de usuário e domínio (por exemplo, fulano@pucminas.br).
//// O método deve retornar um vetor contendo todos os e-mails que terminam com o domínio especificado.

using System.Text;
using System;
using System.IO;

namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Verifica se o email informado termina com o domínio especificado.
        /// </summary>
        static public string VerificarEmail(string email, string dominio)
        {
            if ((email != null || email != "") && email.EndsWith(dominio))
                return email;

            return "";
        }

        static public bool InterageComArquivo(string path_i, string path_o)
        {
            try
            {
                // Abre arquivo para leitura
                StreamReader arq = new StreamReader(path_i, Encoding.UTF8);
                StreamWriter arqw = new StreamWriter(path_o, false, Encoding.UTF8);
                {
                    // Primeira linha: domínio
                    string dominio = arq.ReadLine();

                    // Agora lê linha por linha (cada email)
                    string linha = arq.ReadLine();
                    while (linha != null)
                    {
                        string emailVerificado = VerificarEmail(linha, dominio);
                        if (emailVerificado != "")
                        {
                            arqw.WriteLine(emailVerificado);
                        }
                        linha = arq.ReadLine();
                    }
                }

                //
                arq.Close();
                arqw.Close();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool action = InterageComArquivo(
                "C:\\Code\\C#\\repos\\POO_Lista_1\\Ex6\\emails.txt",
                "C:\\Code\\C#\\repos\\POO_Lista_1\\Ex6\\emailsVerificados.txt"
            );

            Console.WriteLine(action);
        }
    }
}
