//4) Crie um programa que embaralha ("criptografa") uma string usando o seguinte algoritmo:
//a string é reescrita em blocos de 5 caracteres, sendo as novas palavras obtidas lendo-se cada coluna resultante,
//separadas por asteriscos. Por exemplo, se a string for "mensagem secreta":

//mensa
//gem s
//ecret
//a

//A criptografia retorna "mgea*eec *nmr *s e *ast *" (atenção para os espaços em branco).
//O programa deve, também, ser capaz de receber uma string criptografada com o método descrito e retornar
//uma string "simples" com a mensagem original.

using System.Text;

namespace Ex4
{
    internal class Program
    {
        static string Criptografia(string mensagem)
        {
            int tamanho = mensagem.Length;
            int linhas = tamanho / 5;
            int acrescimo = tamanho % 5 > 0 ? 1 : 0;
            char[] vtr_mensagem = mensagem.ToCharArray();
            int contador = 0;

            StringBuilder sb = new StringBuilder();

            char[,] mtz_mensagem = new char[linhas + acrescimo + 1, 5];

            for (int i = 0; i < mtz_mensagem.GetLength(0); i++)
            {
                for (int j = 0; j < mtz_mensagem.GetLength(1); j++)
                {
                    if (i == mtz_mensagem.GetLength(0) - 1)
                        mtz_mensagem[i, j] = '*';
                    else
                        if (contador < vtr_mensagem.Length)
                            mtz_mensagem[i, j] = vtr_mensagem[contador];
                        else
                            mtz_mensagem[i, j] = ' ';
                    contador++;
                }
            }

            for (int j = 0; j < mtz_mensagem.GetLength(1); j++)
            {
                for (int i = 0; i < mtz_mensagem.GetLength(0); i++)
                {
                    sb.Append(mtz_mensagem[i,j]);
                }
            }


            return sb.ToString();
        }

        static string Descriptografia(string mensagem)
        {
            int tamanho = mensagem.Length;
            int linhas = tamanho / 5;
            char[] vtr_mensagem = mensagem.ToCharArray();
            int contador = 0;

            StringBuilder sb = new StringBuilder();

            char[,] mtz_mensagem = new char[linhas, 5];

            for (int j = 0; j < mtz_mensagem.GetLength(1); j++)
            {
                for (int i = 0; i < mtz_mensagem.GetLength(0); i++)
                {
                    mtz_mensagem[j, i] = vtr_mensagem[contador];
                    contador++;
                }
            }

            for (int j = 0; j < mtz_mensagem.GetLength(1)-1; j++)
            {
                for (int i = 0; i < mtz_mensagem.GetLength(0); i++)
                {
                    sb.Append(mtz_mensagem[i, j]);
                }
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            // "mgea*eec *nmr *s e *ast *
            string mensagem = "mensagem secreta";

            string mensagem_criptografada = Criptografia(mensagem);
            Console.WriteLine($"Mensagem Criptografada: {mensagem_criptografada}");

            string mensagem_descriptografada = Descriptografia(mensagem_criptografada);
            Console.WriteLine($"Mensagem Descriptografada: {mensagem_descriptografada}");
        }
    }
}
