using System;



namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            //Console.WriteLine(now);
            var toDay = DateTime.Today;
            //Console.WriteLine(toDay);
    //      Console.WriteLine("Hour: " + now.Hour);
     //     Console.WriteLine("Minute: " + now.Minute);             // not understanding well
       //   Console.WriteLine("Hour: " + toDay.Hour);
         // Console.WriteLine("Minutes: " + now.Minute);

           // now.AddHours
            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(tomrrow);
            Console.WriteLine(yesterday);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));

        }
    }
}
