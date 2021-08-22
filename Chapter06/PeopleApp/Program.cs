using Packt.Shared;
using static System.Console;

var harry = new Person{Name = "Harry"};
var mary = new Person{Name = "Mary"};
var jill = new Person{Name = "Jill"};

// call instance method
var baby1 = mary.Procreate(harry);

// call static method
var baby2 = Person.Procreate(harry, jill);

// use operator * to implement method Procreate
var baby3 = mary * harry;
WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");

WriteLine($"12! is {MathOperation.Factorial(12)}");

static void Harry_Shout(object sender, EventArgs e)
{
    Person p = (Person)sender;
    WriteLine($"{p.Name} is angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Person[] people={
    new Person{Name = "Simon"},
    new Person{Name = "Jenny"},
    new Person{Name = "Adam"},
    new Person{Name = "Richard"}
};
WriteLine("Initial list of people:");
foreach(var p in people)
{
    WriteLine(p.Name);
}
WriteLine("Use Person's IComparable implementation to sort: ");
Array.Sort(people);
foreach(var p in people)
{
    WriteLine(p.Name);
}
WriteLine("Use PersonComparer's IComparer implementation to sort: ");
Array.Sort(people, new PersonComparer());
foreach(var p in people)
{
    WriteLine(p.Name);
}

DvdPlayer dvdplayer = new DvdPlayer();
dvdplayer.Play();
dvdplayer.Pause();
// dvdplayer.Stop();

var gt1 = new GenericThing<int>();
gt1.Data = 42;
WriteLine($"GenericThing with an integer:{gt1.Process(42)}");

static void Test<T>(T input) where T:IComparable
{
    WriteLine(input.ToString());
}

Test<int>(25);

DisplaymentVector v1 = new DisplaymentVector(2, 3);

DisplaymentVector v2 = new DisplaymentVector(5, 8);

WriteLine($"v1+v2 is: {(v1+v2).X}, {(v1+v2).Y}");
WriteLine(nameof(v1));

Employee john = new Employee{
    Name="John Jones",
    DateOfBirth=new DateTime(1990, 7, 28),
    EmployeeCode = "JJ001",
    HireDate = new DateTime(2014,11,23)
};
john.WriteToConsole();
((Person)john).WriteToConsole();
john.WriteName();
((Person)john).WriteName(); // 使用的仍然是新方法的实现， 也就是可以使用Person统一处理
Person aliceInPerson = new Person();
// Employee aliceInEmployee = (Employee)aliceInPerson; // 必须使用强制类型转换
// WriteLine("Convert done.");
try
{
    john.TimeTravel(new DateTime(1999,12,31));
    john.TimeTravel(new DateTime(1950,12,25));
}
catch(PersonException ex)
{
    WriteLine(ex.Message);
}
string email1 = "abc@in.com";
string email2 = "ab&@cin.com";
WriteLine($"{email1} an valid e-mail address: {email1.IsValidEmail()}");
WriteLine($"{email2} an valid e-mail address: {email2.IsValidEmail()}");