using System;
using System.Globalization;

namespace CoordenadasPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ponto = Console.ReadLine().Split(' ');

            double x = double.Parse(ponto[0]);
            double y = double.Parse(ponto[1]);

            if ( x == 0.0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if ( y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
