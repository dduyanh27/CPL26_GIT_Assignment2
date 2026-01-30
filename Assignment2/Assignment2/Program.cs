using System;

namespace Assignment2_Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Nhap so thu nhat (arg1): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai (arg2): ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Calculate("PLUS", a, b);

            Console.WriteLine($"Ket qua: {result}");
            Console.ReadKey();
        }


        private static double Calculate(string sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case "PLUS":
                    return arg1 + arg2;
                default:
                    return 0;
            }

        }
    }
}
