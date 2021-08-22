using System;

namespace Packt.Shared;

public class MathOperation
{
    public static int Factorial(int number)
    {
        if(number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);

        int localFactorial(int localnumber)
        {
            if(localnumber<1)
            {
                return 1;
            }
            return localnumber * localFactorial(localnumber - 1);
        }
    }
}