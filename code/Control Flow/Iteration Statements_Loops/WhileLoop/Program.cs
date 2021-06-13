using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // showing even numbers using while loop
            int i = 0;
            while(i <= 10)
                {
                    if(i%2 == 0)

                        Console.WriteLine(i);
                i++;

                }

            while(true)               // condition shows infinite iteration
                {
                    Console.WriteLine("Type your name ");
                    var input = Console.ReadLine();

                /*
                    if(String.IsNullOrWhiteSpace(input))          // if we give null value loop will break otherwise it go on
                        break;                                    //Note : not sure about white space
                    Console.WriteLine("@Echo: " + input);

                */
                    if (!string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("@Echo " + input);
                          //  continue;
                        }
                    break;   

                }



                /*
                
                     In first "if" , if condition is true break statement will be excuted 
                    so loop will exited. But loop will excute untill condition is false 
                    this mean we will see output untill condition is false.

                    In second if , if the condition is true then we will see output then break 
                    statement will be excuted. But if condition is false output statement will not 
                    excute after that break statement will be excuted. It means eigther condition is false 
                    or true loop will exit  
                    
                    In third snerio i use the "continue" statement in body of if statement , when condition is
                    true then output and continue statements excuted as "continue statement mean all statemets
                    below it gave up them and continue to excute loop again" so break statement will not run.
                    when condition is false both output and continue statements will not run , break statement 
                    will excute  .
                    
                     */



        }
    }
}
