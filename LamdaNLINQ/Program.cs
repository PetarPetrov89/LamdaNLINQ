using System;
using System.Linq;

namespace LamdaNLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, extension Methods!";
            Console.WriteLine(text.WordCount());
        }


    }
    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '!', ';' }, StringSplitOptions.RemoveEmptyEntries).Length;

        }
    }
}
