using System;

namespace Atividade5
{
    internal class Program
    {
        static void Main()
        {
            // Solicita a nota do aluno
            Console.WriteLine("Digite a nota do aluno (de 0 a 10):");
            if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 10)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira uma nota entre 0 e 10.");
                return;
            }

            // Classifica a nota
            string classificacao;

            switch (nota)
            {
                case >= 9 and <= 10:
                    classificacao = "A";
                    break;
                case >= 7 and < 9:
                    classificacao = "B";
                    break;
                case >= 5 and < 7:
                    classificacao = "C";
                    break;
                case >= 3 and < 5:
                    classificacao = "D";
                    break;
                default:
                    classificacao = "F";
                    break;
            }

            // Exibe a classificação
            Console.WriteLine($"A classificação da nota é: {classificacao}");
        }
    }
}

