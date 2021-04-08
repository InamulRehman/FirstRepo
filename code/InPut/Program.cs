using System;

namespace InPut
{

    class Program
    {
        static void Main(string[] args)
        {
            string myFirstName;
            Console.Write("Enter your First name");
            myFirstName=Console.ReadLine();
            
            string myLastName;
            Console.Write("Enter your Last Name");
            myLastName=Console.ReadLine();

            Console.WriteLine(myFirstName+ " " +myLastName);

        }
    }
}
