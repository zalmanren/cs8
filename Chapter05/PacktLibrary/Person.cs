using System.Collections.Generic;
namespace Packt.Shared;
public partial class Person : Object
{
    public string Name = "";
    public DateTime DateOfBirth;
    // public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new System.Collections.Generic.List<Person>();

    public string HomePlanet;
    
    public override string ToString()
    {
        return string.Format("{0} was born on {1:dddd, d MMM yyyy}", this.Name, this.DateOfBirth);
    }
    // public (string, int) GetFruit()
    // {
    //     return ("Apple", 5);
    // }
    public (string Name, int Number) GetFruit()
    {
        return (Name:"Apples", Number:5);
    }
}
