using System;

namespace DoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1;
            double b = 0.2;
            if(a + b == 0.3)
                Console.WriteLine($"{a} + {b} equals 0.3");
            else
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            

            decimal a2 = 0.1m;
            decimal b2 = 0.2m;
            
            if(a2 + b2 == 0.3M)
                Console.WriteLine($"{a2} + {b2} equals 0.3");
            else
                Console.WriteLine($"{a2} + {b2} does NOT equal 0.3");
        }
    }
}
