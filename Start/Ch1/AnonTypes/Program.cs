// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new {
    Name = "my name",
    Age = 45,
    Address = new {
        Street = "123 Main St.",
        City = "Somewhere"
    }
};
Console.WriteLine($"Name and street address: {myobj.Name}, {myobj.Address.Street}");
Console.WriteLine($"myobj: {myobj}");

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; // will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
var myobj2 = myobj with {Name = "Jane Doe"};
Console.WriteLine($"Name 2 and street address: {myobj2.Name}, {myobj2.Address.Street}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"Property name exists: {myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"Property job exists: {myobj.GetType().GetProperty("Job") != null}");
