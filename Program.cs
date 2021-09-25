using System;

namespace TeoremaHeron
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, p, a;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== Teorema de Heron =====\n");
            Console.ResetColor();
            
            Console.WriteLine("Digite a medida dos 3 lados\nde seu triângulo, para que\neu possa calcular a área.\n");
            
            Console.Write("Lado 1...: ");
            l1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2...: ");
            l2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3...: ");
            l3 = Convert.ToDouble(Console.ReadLine());

            p = (l1 + l2 + l3) / 2;

            a = Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n== Resultado ==\n");
            Console.ResetColor();

            Console.WriteLine($"Semiperímetro..= {p}");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Área...........= {a}\n");
            Console.ResetColor();
        }
    }
}
