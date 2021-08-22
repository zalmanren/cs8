using System;
using static System.Console;
namespace Packt.Shared;
public class Person : Object, IComparable<Person>
{
    // 字段
    public string Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new List<Person>();

    // 方法
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on  a {DateOfBirth:dddd}");
    }
    public virtual void WriteName()
    {
        WriteLine(Name);
    }
    // static method to "multiply"
    public static Person Procreate(Person p1, Person p2)
    {
        var baby = new Person{
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }
    public Person Procreate(Person partner)
    {
        return Procreate(this, partner);
    }
    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }

    // event delegate field
    // public EventHandler Shout;
    public event EventHandler Shout;
    // data field
    public int AngerLevel;
    // method
    public void Poke()
    {
        AngerLevel++;
        if(AngerLevel>=3)
        {
            // if someting is listening...
            if(Shout!=null)
            {
                // ... then call the delegate
                Shout(this, EventArgs.Empty);
            }
        }
    }
    public int CompareTo(Person other)
    {
        return Name.CompareTo(other.Name);
    }

    public void TimeTravel(DateTime when)
    {
        if(when <= this.DateOfBirth)
        {
            throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
        }
    }
}
