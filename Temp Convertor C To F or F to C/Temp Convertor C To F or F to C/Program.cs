using System;

namespace Temp_Convertor_C_To_F_or_F_to_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISFR Temp Convertor (C to F or F to C)");
            Console.WriteLine("Please pick either C to F or F to C (Type 'C to F' or 'F to C)");
            string myConver = Console.ReadLine();
            Console.WriteLine("Awesome Now select a degree!");
            double myDeg = double.Parse(Console.ReadLine());
            if (myConver.Contains("C to F"))
            {
                double myNewDeg = ((myDeg * 9 / 5) + 32);
                Console.WriteLine(myNewDeg);
            }
            else if (myConver.Contains("F to C"))
            {
                double mySecondDeg = ((myDeg - 32) * 5/9);
                Console.WriteLine(mySecondDeg);
            }
        }
    }
}