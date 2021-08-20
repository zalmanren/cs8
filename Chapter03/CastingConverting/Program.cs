// See https://aka.ms/new-console-template for more information
using static System.Convert;
double[] doubles = new [] {
    9.49, 9.5, 9.51, 10.49, 10.5, 10.51
};
foreach(double d in doubles)
{
    Console.WriteLine($"ToInt({d}) is {ToInt32(d)}");
}
// Console.WriteLine(Math.Round(9.5d, 0, MidpointRounding.AwayFromZero));
// Console.WriteLine(Math.Round(9.49d, 0, MidpointRounding.AwayFromZero));
// Console.WriteLine(Math.Round(10.5d, 0, MidpointRounding.AwayFromZero));
// Console.WriteLine(Math.Round(9.5d, 0, MidpointRounding.ToEven));
// Console.WriteLine(Math.Round(9.49d, 0, MidpointRounding.ToEven));
// Console.WriteLine(Math.Round(10.5d, 0, MidpointRounding.ToEven));
// Console.WriteLine(Math.Round(9.5d, 0, MidpointRounding.ToNegativeInfinity));
// Console.WriteLine(Math.Round(9.49d, 0, MidpointRounding.ToNegativeInfinity));
// Console.WriteLine(Math.Round(10.5d, 0, MidpointRounding.ToNegativeInfinity));
// Console.WriteLine(Math.Round(10.6d, 0, MidpointRounding.ToNegativeInfinity));

Console.WriteLine(1d/0);