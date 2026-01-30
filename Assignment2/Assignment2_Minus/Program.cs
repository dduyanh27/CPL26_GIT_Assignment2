using System;

namespace Assignment2_Minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = Calculate("MINUS", a, b);

            Console.WriteLine($"Ket qua: {result}");
            Console.ReadKey();
        }

        private static double Calculate(string sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case "MINUS":
                    return arg1 - arg2;
                default:
                    return 0;
            }
        }
    }
}
