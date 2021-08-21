using Packt.Shared;
using static System.Console;

var bob = new Person();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
// bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.StatueOfZeusAtOlympia | WondersOfTheAncientWorld.ColossusOfRhodes;
bob.Children.Add(new Person(){Name="Alfred"});
bob.Children.Add(new Person(){Name="Zoe"});
WriteLine("{0} was born on {1:dddd, d MMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);
// WriteLine("{0}'s favorite wonder is {1}. It's integer is {2}",
//     arg0: bob.Name,
//     arg1: bob.FavoriteAncientWonder,
//     arg2: (int)bob.FavoriteAncientWonder);
WriteLine("{0}'s bucket list is {1}. It's integer is {2}",
    arg0: bob.Name,
    arg1: bob.BucketList,
    arg2: (int)bob.BucketList);

WriteLine($"{bob.Name} has {bob.Children.Count} children: ");
foreach(var child in bob.Children)
{
    Console.WriteLine(child.Name);
}


var alice = new Person(){
    Name="Alice Jones",
    DateOfBirth=new DateTime(1998, 3, 7)};
WriteLine("{0} was born on {1:dddd, d MMM yyyy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);

var jim = new Person(){
    Name="Jim Green",
    DateOfBirth=new DateTime(1998, 3, 7)};
WriteLine(jim.ToString());

ThingOfDefault tod = new ThingOfDefault();
Console.WriteLine(tod.Name);
Console.WriteLine(tod.Population);

var fruit = bob.GetFruit();
Console.WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
Console.WriteLine($"{fruit.Name}, {fruit.Number} there are.");
(string fruitName, int fruitNumber) = bob.GetFruit();
Console.WriteLine($"{fruitName}, {fruitNumber} there are.");

WriteLine(bob.Greeting);
WriteLine(bob.Origin);
WriteLine(bob.Age);
WriteLine(bob[0].Name);
