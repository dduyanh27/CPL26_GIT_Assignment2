using System;

namespace Assignment2_Divide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = Calculate("DIVIDE", a, b);

            Console.WriteLine($"Ket qua: {result}");
            Console.ReadKey();
        }

        private static double Calculate(string sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case "DIVIDE":
                    return arg2 != 0 ? arg1 / arg2 : 0;
                default:
                    return 0;
            }
        }
    }
}
