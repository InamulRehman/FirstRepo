using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter Width: ");
           var width = int.Parse(Console.ReadLine());

           Console.Write("Enter Height: ");
           var height = int.Parse(Console.ReadLine());

           if (width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }
        }
    }
}
