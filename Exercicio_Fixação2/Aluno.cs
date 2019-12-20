using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Fixação2
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        
        public double CalculaMedia(double a, double b, double c)
        {
            return a + b + c;
        }

        public void Aprovacao(double d)
        {
            if (d >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double f = Faltou(d);
                Console.WriteLine("FALTARAM: " + f.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }

        public double Faltou(double e)
        {
            return 60 - e;
        }
        
    }
}
