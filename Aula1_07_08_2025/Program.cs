using System;

namespace Aula1_07_08_2025
{
    internal class Program
    {
        // Ex 2) 
        static void Main(string[] args)
        {
            int altura, largura, deslocamento;
            

            Console.WriteLine("Insira os valores de altura: ");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os valores de largura: ");
            largura = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os valores de deslocamento: ");
            deslocamento = int.Parse(Console.ReadLine());

            char[,] draw = new char[altura, largura];


            for(int i = 0; i < draw.GetLength(0); i++)  // Itera sobre as linhas
            {
                for (int j = 0; j < draw.GetLength(1); j++)  // Itera sobre as coluna
                {
                    if (i == 0 || j == 0 || i == altura - 1 || j == largura-1)
                        draw[i, j] = 'X';
                    else
                        draw[i, j] = ' ';
                }
            }

            for (int i = 0; i < draw.GetLength(0); i++)
            {
                for (int x = 0; x < deslocamento; x++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < draw.GetLength(1); j++)
                {
                    Console.Write(draw[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
