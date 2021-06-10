using System;

namespace Enums
{

    public enum  ShipingMethod{

        RegularAirMail = 1, 
        RegisteredAirMail = 2,
        Express = 3                // enums does not end with semicolon
    }
    class Program
    {
        static void Main(string[] args)
        {
           var method = ShipingMethod.Express;
           Console.WriteLine((int)method);        // string value to integer of enum

           var methodID = 3;                        // we have a variable outside from 
           Console.WriteLine((ShipingMethod)methodID);          // showing outside variable reletive to enum

           Console.WriteLine(method.ToString());        // will take integer from method enum , convert it to string enum

           Console.WriteLine(method);

           var methodName = "Express";
           var shipingMethod = (ShipingMethod)Enum.Parse(typeof(ShipingMethod) , methodName);  // parsing methodName to shipingMethod of type enum and casrting to shippingmethod of type enum , storing returned value into shipingMethod
            Console.WriteLine(shipingMethod);
        }
    }
}
