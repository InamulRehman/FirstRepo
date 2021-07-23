using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speed limit: ");
            var speedLimit = int .Parse(Console.ReadLine());

            Console.Write("Enter speed of car: ");
            var speedOfCar = int .Parse(Console.ReadLine());

            var demeritPoints = 0;
            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                
                var expression = (speedOfCar - speedLimit)/5;  
                for (var i=1; i <= expression; i++)
                    {
                        demeritPoints++;
                        Console.WriteLine(demeritPoints);
                    }
                if (demeritPoints >= 12)
                    {
                        Console.WriteLine("License Suspended");
                    }  
                else
                    {
                        Console.WriteLine("Ooo you saved your license form suspension");
                    }
                    
            }

        }





        // static void Main(string[] args)
        // {


        //     Console.Write("Speed Limit: ");
        //     var speedLimit = int .Parse(Console.ReadLine());
            
        //     //Console.WriteLine("SPEED LIMIT : " + speedLimit);
            

        //     Console.Write("Speed of car: ");
        //     var speedOfCar = int .Parse(Console.ReadLine());
        //     var demeritPoints = 0;
        //     if (speedOfCar < speedLimit)
        //         {
        //             Console.WriteLine("Ok");
        //         }
        //      else
        //         {
        //             var expression = (speedOfCar - speedLimit)/5;

        //             for (int counter =1; counter <= expression; counter++)
        //             {
                          
        //                 demeritPoints++;
        //                 Console.Write("Demerit Points :");
        //                 Console.WriteLine(demeritPoints);
                        
        //             }
        //         }
        //     Console.WriteLine("***********************");
        //     Console.Write("Total no. of demerit points :");
        //     Console.WriteLine(demeritPoints);

        //     if (demeritPoints >= 12)
        //         {
        //             Console.WriteLine("License Suspended");
        //         }
                
        // }  

       
        
        
    }
}
