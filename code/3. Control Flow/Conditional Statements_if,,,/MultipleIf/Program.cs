using System;

namespace MultipleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)             // multiple if else structure

                Console.WriteLine("It's morning");
                                                         // we will use curly braces {} when there are more than one statements
            else if (hour >= 12 && hour < 18 )

                Console.WriteLine("It's afternoon");

            else

                Console.WriteLine("It's evening");

            bool isGoldCustomer = true;//not understanding about working
            
            float price;
            if (isGoldCustomer)                       // simple if else structure
                price = 19.95f;
            else
                price = 29.95f;
            Console.WriteLine(price);
            

            float pri = (isGoldCustomer) ? 19.95f : 29.95f;      // conditional operator works just like simple if else structure
            Console.WriteLine(pri);

                


            
        }
    }
}
