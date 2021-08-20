// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] names = {"Adam", "Barry", "Charilie"};
foreach(string name in names)
{
    Console.WriteLine($"{name} has {name.Length} characters.");
}