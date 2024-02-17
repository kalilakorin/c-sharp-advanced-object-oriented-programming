// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog {Name="Fido", Age=4, IsTrained=true};
Cat cat = new Cat {Name="Mr. Meowington", Age=7, IsDeclawed=false};
Console.WriteLine($"Dog name, age: {dog.Name}, {dog.Age}");
Console.WriteLine($"Dog: {dog}");
Console.WriteLine($"Cat name, age: {cat.Name}, {cat.Age}");
Console.WriteLine($"Cat: {cat}");

// TODO: Initializers can be used on anonymous types
var pet = new {Name = "Charles", Age = 5};
Console.WriteLine($"Pet name, age: {pet.Name}, {pet.Age}");
Console.WriteLine($"Pet: {pet}");

// TODO: Collections can also be initialized this way
int[] numbers = new int[] {1,2,3,4,5,6};
Console.WriteLine($"Numbers: {numbers}");
Console.WriteLine($"Numbers length: {numbers.Length}");
Console.WriteLine($"Numbers members: ");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// TODO: Initialize a collection with a set of objects
PetOwner owner = new PetOwner {
    Name="The owner",
    Pets = new List<Pet> {
        new Dog { Name = "Junebug", Age = 4 },
        new Cat { Name = "Mr. Whiskers", Age = 3 },
        new Dog { Name = "Max", Age = 10 }
    }
};
Console.WriteLine($"{owner.Name}'s pets:");
foreach (Pet p in owner.Pets) {
    Console.WriteLine($"{p.Name}");
}
