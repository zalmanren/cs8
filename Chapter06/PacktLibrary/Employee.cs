using System;
using static System.Console;
namespace Packt.Shared;

public class Employee:Person
{
    public string EmployeeCode{set;get;}
    public DateTime HireDate{set;get;}
    public new void WriteToConsole()
    {
        WriteLine($"{Name} was born on {DateOfBirth:dd/MM/yy} and hired on {HireDate:dd/MM/yy}");
        base.WriteToConsole();
    }
    public override void WriteName()
    {
         WriteLine("Employee: " + Name);
    }
}