using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // default value, using default()
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
