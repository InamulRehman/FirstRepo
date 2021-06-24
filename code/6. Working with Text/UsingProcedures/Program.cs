using System;
using System.Collections.Generic;

namespace UsingProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers = new List<int>();

        
           while(true)
            {
                Console.Write("Enter a number ( or 'quit' to exit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));  
            }

    
            Console.WriteLine("Unique Numbers: ");
            
            foreach(var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);

         static List<int> GetUniqueNumbers(List<int>numbers)
         {
            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if(!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
          } 


    

        }
        
    }
}
