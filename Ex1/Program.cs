using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            int opcao;
            int[] vet = null;
            bool vetorPreenchido = false;

            do
            {
                Console.WriteLine("Informe a operação que deseja fazer no sistema: ");
                Console.WriteLine(" 1 - Dividir dois números.\r\n 2 – Ler 3 números e mostrar qual é o maior deles.\r\n 3 – Ler e armazenar N números.\r\n 4 – Mostrar a soma dos números armazenados.\r\n 5 - Contar quantos dos números armazenados são pares e quantos são ímpares.\r\n 0 - Sair\r\n\n\n Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Dividir dois números: ");

                        Console.WriteLine("Informe o primeiro número: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        n2 = int.Parse(Console.ReadLine());

                        double divisao = n1 / (double)n2;

                        Console.WriteLine($"O Resultado da divisão é: {divisao}");
                        break;

                    case 2:
                        Console.WriteLine("Ler 3 números e mostrar qual é o maior deles: ");

                        Console.WriteLine("Informe o primeiro número: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o terceiro número: ");
                        n3 = int.Parse(Console.ReadLine());

                        if (n1 >= n2 && n1 >= n3)
                            Console.WriteLine($"O maior número é: {n1}");
                        else if (n2 >= n1 && n2 >= n3)
                            Console.WriteLine($"O maior número é: {n2}");
                        else
                            Console.WriteLine($"O maior número é: {n3}");
                        break;

                    case 3:
                        Console.WriteLine("Ler e armazenar N números: ");

                        Console.WriteLine("Informe o tamanho do vetor: ");
                        int len = int.Parse(Console.ReadLine());

                        if (len <= 0)
                        {
                            Console.WriteLine("Tamanho inválido. Tente novamente.");
                            vetorPreenchido = false;
                            vet = null;
                            break;
                        }

                        vet = new int[len];
                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.WriteLine($"Informe o {i + 1}º número: ");
                            vet[i] = int.Parse(Console.ReadLine());
                        }

                        vetorPreenchido = true;
                        Console.WriteLine("Vetor preenchido com sucesso!");
                        break;

                    case 4:
                        if (!vetorPreenchido || vet == null || vet.Length == 0)
                        {
                            Console.WriteLine("O vetor ainda não foi criado/preenchido (use a opção 3).");
                            break;
                        }

                        long soma = 0;
                        for (int i = 0; i < vet.Length; i++)
                        {
                            soma += vet[i];
                        }
                        Console.WriteLine($"Soma dos números armazenados: {soma}");
                        break;

                    case 5:
                        if (!vetorPreenchido || vet == null || vet.Length == 0)
                        {
                            Console.WriteLine("O vetor ainda não foi criado/preenchido (use a opção 3).");
                            break;
                        }

                        int pares = 0, impares = 0;
                        for (int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] % 2 == 0) pares++;
                            else impares++;
                        }
                        Console.WriteLine($"Pares: {pares} | Ímpares: {impares}");
                        break;

                    case 0:
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
