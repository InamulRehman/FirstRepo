using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            
            numbers.AddRange(new int[3] {5, 6, 7} );
            foreach(var number in numbers)
                Console.WriteLine(number);
            
            Console.WriteLine("Index of 2 is: " + numbers.IndexOf(2));
            Console.WriteLine("Last Index of 3: " + numbers.LastIndexOf(3));  // not understanding working properly
            Console.WriteLine("Count: " + numbers.Count);



            
            //numbers.Remove(5);                // why not other/second one
            

                                                                      /* foreach(var number in numbers)
                                                                            {
                         unhandled exception                                    if(number == 1)
                                                                                    numbers.Remove(number);
                                                                            }  */
            for(var i=0; i < numbers.Count; i++)
                {
                    if (numbers[i] == 1)
                        numbers.Remove(numbers[i]);
                }
            foreach(var number in numbers)
                Console.WriteLine(number);

            
            numbers.Clear();
            Console.WriteLine("After clear affect count is: " + numbers.Count );

        }
    }
}
