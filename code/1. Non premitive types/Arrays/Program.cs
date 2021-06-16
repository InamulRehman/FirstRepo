using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[4];

            numbers [0] = 14;
            numbers [1] = 50;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);


            var value = new bool[4];

            value [0] = true;
            value [1]= false;

            Console.WriteLine(value[0]);
            Console.WriteLine(value[1]);
            Console.WriteLine(value[2]);
            Console.WriteLine(value[3]);
        }
    }
}
