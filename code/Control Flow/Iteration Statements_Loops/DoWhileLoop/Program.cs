using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var i=0;
            do {

                if (i%2 ==0)
                    Console.WriteLine(i);              // in this loop will excute once either condition is true/false
                    i++;                            // also this loop terminated by semicolon unlike while loop
                    
            }while(i<=10);
        }
    }
}
