using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Length
            var number = new []{2, 3, 5, 89, 54, 2, 9, 30};     //point []
            Console.WriteLine("Length: " + number.Length);      // see description /overload

            // IndexOf()

            //Array.
            //number.Initialize
            var index = Array.IndexOf(number ,89 );
            Console.WriteLine("Index of 89: " + index);
                                                                     
            // Clear()
            Array.Clear(number, 2,3);
            Console.WriteLine("Effect of Clear() ");
            foreach(var n in number)
                {
                    Console.WriteLine(n);
                }
            
            //Copy()
            int [] another = new int[3];              // no understanding about int[]
            Array.Copy(number, another, 3);
            Console.WriteLine("Effect of Copy() ");
            foreach(var n in another)
                Console.WriteLine(n);
            
            //Sort()
            Array.Sort(number);
            Console.WriteLine("Effect of Sort() ");
            foreach(var n in number)
                Console.WriteLine(n);
            
            //Reverse
            Array.Reverse(number);
            Console.WriteLine("Effect of Reverse() ");
            foreach(var n in number)
                Console.WriteLine(n);


            
        }
    }
}
