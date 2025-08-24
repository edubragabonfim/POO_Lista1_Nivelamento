// 5) Crie um método public string[] VerificarEmail(string[] emails, string dominio).
// Este método recebe um vetor de strings e o nome de um domínio como parâmetro.
// Cada posição do vetor possui um endereço de e-mail, com nome de usuário e domínio (por exemplo, fulano@pucminas.br).
// O método deve retornar um vetor contendo todos os e-mails que terminam com o domínio especificado.

namespace Ex5
{
    internal class Program
    {
        static public string[] VerificarEmail(string[] emails, string dominio)
        {
            int contador = 0;
            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i].EndsWith(dominio))
                    contador++;
            }

            string[] emailsVerificados = new string[contador];

            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i].EndsWith(dominio))
                    emailsVerificados[i] = emails[i];
            }

            return emailsVerificados;

        }
        static void Main(string[] args)
        {
            string[] emails = { "luis.martins82@gmail.com", "ana.clara947@gmail.com", "ricardo.souza17@gmail.com", 
                "carolina_fernandes@outlook.com", "joao.silva@protonmail.com" };

            string[] verificados = VerificarEmail(emails, "@gmail.com");

            for (int i = 0; i < verificados.Length; i++)
                Console.WriteLine(verificados[i]);

        }
    }
}
