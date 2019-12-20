using System;
using System.Globalization;

namespace Exercicio_Fixação2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno:");
            a1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = a1.CalculaMedia(a1.N1, a1.N2, a1.N3);
            Console.WriteLine("NOTA FINAL: " + media.ToString("F2", CultureInfo.InvariantCulture));
            a1.Aprovacao(media);
        }
    }
}
