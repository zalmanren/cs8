using static System.Console;
// See https://aka.ms/new-console-template for more information
A_Label:
    var number = (new Random()).Next(1, 7);
Console.WriteLine($"My random number is: {number}");
switch(number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        Console.WriteLine("Three or Four");
        goto case 1;
    case 5:
        System.Threading.Thread.Sleep(500);
        goto A_Label;
    default:
        Console.WriteLine("Default");
        break;
    
}
