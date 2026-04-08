// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Text.Json;

Console.WriteLine("Hello, World!");
#region copy

// normal copy 
Person original = new Person { Name = "Alice", Age = 25, Address = new Address { City = "Delhi" } };
Person copy = original;

copy.Name = "Bob";
copy.Address.City = "Mumbai";
Console.WriteLine("Normal  copy================");
Console.WriteLine(original.Name);  // Bob
Console.WriteLine(copy.Name);      // Bob

Console.WriteLine(original.Address.City);  // Delhi
Console.WriteLine(copy.Address.City);      // Mumbai



// Shallow copy

Person shallowcopy = original.ShallowCopy();

shallowcopy.Name = "Charlie";
shallowcopy.Address.City = "Mumbai123";

Console.WriteLine("Shallow copy================" );
Console.WriteLine("If I have a Person object with a Name and an Address object, a shallow copy will create a new Person object, but both the original and the copy will share the same Address object. So changing the address in the copy will affect the original.”");
Console.WriteLine(original.Name);  // Bob
Console.WriteLine(shallowcopy.Name);      // Charlie
Console.WriteLine(original.Address.City);  // Delhi
Console.WriteLine(shallowcopy.Address.City);      // Mumbai



// deep copy  
Console.WriteLine("Deep copy================");
Console.WriteLine("In a deep copy, both the Person and the nested Address object are copied. Changing the address in the copy does not affect the original.");
Person deepcopy = original.DeepCopy();
deepcopy.Name = "yasho";
deepcopy.Address.City = "Mumbai456";
Console.WriteLine(original.Name);  // Bob
Console.WriteLine(deepcopy.Name);      // yasho
Console.WriteLine(original.Address.City);  // Delhi
Console.WriteLine(deepcopy.Address.City);      // Mumbai

Console.WriteLine("Deep copy using json serializer================");
Console.WriteLine("Circular ref shared ref copy const need to study ");

var originaljson = JsonSerializer.Serialize(original);
var deepcopyjson = JsonSerializer.Deserialize<Person>(originaljson);



class Address
{
    public string City;
}
class Person
{
    public string Name;
    public int Age;
    public Address Address;

    // Shallow copy using MemberwiseClone
    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }
    // Deep copy method Manual Deep Copy (Most Common & Preferred)
    public Person DeepCopy()
    {
        return new Person
        {
            Name = this.Name,
            Age = this.Age,
            Address = new Address { City = this.Address.City } // new object! 
        };
    }

}

#endregion