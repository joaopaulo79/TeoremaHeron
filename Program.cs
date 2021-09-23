using System;

namespace TeoremaHeron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==== Teorema de Heron =====");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite a medida dos 3 lados\nde seu triângulo, para que\neu possa calcular.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Medida do primeiro lado..: ");
            Console.ResetColor();
            string lado1 = Console.ReadLine();
            double L1 = Convert.ToDouble(lado1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Medida do segundo lado...: ");
            Console.ResetColor();
            string lado2 = Console.ReadLine();
            double L2 = Convert.ToDouble(lado2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Medida do terceiro lado..: ");
            Console.ResetColor();
            string lado3 = Console.ReadLine();
            double L3 = Convert.ToDouble(lado3);
            double SP = (L1 + L2 + L3) / 2;
            double H = Math.Sqrt(SP * (SP - L1) * (SP - L2) * (SP - L3));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("== Resultado ==");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"Lado 1........= {L1}");
            Console.WriteLine($"Lado 2........= {L2}");
            Console.WriteLine($"Lado 3........= {L3}");
            Console.WriteLine($"Semipeímetro..= {SP}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Área..........= {H:N2}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
