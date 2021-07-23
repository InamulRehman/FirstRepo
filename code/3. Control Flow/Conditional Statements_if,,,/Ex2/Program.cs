using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number1: ");
            var n1 =Console.ReadLine();
            var num1 = int.Parse(n1);

            Console.Write("Enter number2: ");
            var n2 =Console.ReadLine();
            var num2 = int.Parse(n2);

            if (num1 > num2)
            {
                Console.WriteLine("Number1 is maxmimum.");
            }
            else
            {
                Console.WriteLine("Number2 is maxmimum.");
            }

        }
    }
}
