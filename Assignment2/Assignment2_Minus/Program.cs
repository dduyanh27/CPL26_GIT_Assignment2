using System;

namespace Assignment2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat (arg1): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai (arg2): ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Calculate("MINUS", a, b);

            Console.WriteLine($"Ket qua: {result}");
            Console.ReadKey();
        }

        //minus

        private static double Calculate(string sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case "PLUS": return arg1 + arg2;
                case "MINUS": return arg1 - arg2;
                case "MULTIPLY": return arg1 * arg2;
                case "DIVIDE": return arg2 != 0 ? arg1 / arg2 : 0;
                default: return 0;
            }
        }
    }
}