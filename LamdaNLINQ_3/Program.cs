using System;
using System.Linq;
using System.Collections.Generic;

namespace LamdaNLINQ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 4, 5, 2, 4, 5, 6, 7 };
            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
