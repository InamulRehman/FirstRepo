using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var i = Console.ReadLine();
            var num = int.Parse(i);
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
