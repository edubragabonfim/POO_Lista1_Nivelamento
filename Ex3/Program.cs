//3) Um professor avalia seus alunos através dos seguintes critérios:

//a) Quatro notas de exercícios de 0 a 10, com peso de 20% na nota final.
//b) Duas notas de prova de 0 a 100, com peso de 60% na nota final.
//c) Um trabalho prático de 20 pontos.

//Elabore um programa que lê as notas de um aluno, calcula e mostra na tela sua nota final (em 100 pontos),
//formatada com duas casas decimais e devidamente ponderada pelos pesos.

namespace Ex3
{
    internal class Program
    {
        static int LerInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int ex1, ex2, ex3, ex4;
            int prova1, prova2;
            int trabalho;

            ex1 = LerInteiro("Informe a nota do exercício 1: ");
            ex2 = LerInteiro("Informe a nota do exercício 2: ");
            ex3 = LerInteiro("Informe a nota do exercício 3: ");
            ex4 = LerInteiro("Informe a nota do exercício 4: ");

            prova1 = LerInteiro("Informe a nota da 1ª prova: ");
            prova2 = LerInteiro("Informe a nota da 2ª prova: ");

            trabalho = LerInteiro("Informe a nota do trabalho: ");

            // colocando na mesma escala
            double s_exercicios = (((ex1 + ex2 + ex3 + ex4) / 40) * 100) * 0.2;
            double s_provas = ((prova1 + prova2) / 2) * 0.6;
            double s_trabalho = ((trabalho / 20) * 100) * 0.2;

            double calculo = s_exercicios + s_provas + s_trabalho;

            Console.WriteLine($"Nota final {calculo}");
        }
    }
}
