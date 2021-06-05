using System;
//using CsharpClasses;
using CsharpClasses.Math;

namespace CsharpClasses
{
    
    class Program                                                  // main class
    {
        static void Main(string[] args)
        { 
            // Person MyName = new Person();                              // object MyName of type Person class 
                var MyName = new Person();                                // object MyName of type var
                MyName.FirstName = "Inam ul";                             //  assigning value using dot operator to object MyName of class Person
                MyName.LastName  = "Rehman";                           
                MyName.Name();                                            //  calling method of class



                Calculator calculate = new Calculator();
                var sum = calculate.Add(1 , 2);
                Console.WriteLine(sum);
        }
    }
}
