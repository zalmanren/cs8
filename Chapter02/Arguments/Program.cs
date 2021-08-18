using static System.Console;

// WriteLine($"There are {args.Length} arguments.");
// foreach(var arg in args)
//     Console.WriteLine(arg);

// use parameters to changed the background color and foreground color
if(args.Length < 4)
{
    WriteLine("You must specify two colors and dimensions, e.g.");
    WriteLine("dotnet run red yellow 80 40");
    return;
}
ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);
BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);
WindowWidth = int.Parse(args[2]);
WindowHeight = int.Parse(args[3]);

Console.WriteLine("Setting Done.");
