using System;
using System.Linq;

namespace LamdaNLINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new { Color = "Red", Brand = "Mercedes", Speed = "220" };

            Console.WriteLine($"My car is {myCar.Brand} {myCar.Color}.");
            Console.WriteLine(myCar.ToString());
            Console.WriteLine(myCar.GetType().ToString());
     
        }
    }
}
