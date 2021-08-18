using static System.Console; // 减少以后无需输入Console, 而且现在忽略了命名空间，因为本身都是static的原因
// See https://aka.ms/new-console-template for more information
WriteLine("Hello, World!");
var address = new Addres();
Console.WriteLine(address.City);

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", 
    arg0:key.Key, 
    arg1:key.KeyChar,
    arg2:key.Modifiers);
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", 
    key.Key, 
    key.KeyChar,
    key.Modifiers);
class Addres
{
    public string City = string.Empty;
}
