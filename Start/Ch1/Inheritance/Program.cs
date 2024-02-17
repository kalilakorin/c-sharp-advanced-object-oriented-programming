// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10,20);
Square s = new Square(10);

// TODO: Exercise the ToString() method
Console.WriteLine($"ToString method of c: {c}");
Console.WriteLine($"ToString method of r: {r}");
Console.WriteLine($"ToString method of s: {s}");

// TODO: Use the "is" operator to test an object type
Console.WriteLine($"c is a Shape2D: {c is Shape2D}");
Console.WriteLine($"c is a Rectangle: {c is Rectangle}");

// TODO: Call the GetArea() function on each one
Console.WriteLine($"Area of c: {c.GetArea()}");
Console.WriteLine($"Area of r: {r.GetArea()}");
Console.WriteLine($"Area of s: {s.GetArea()}");

// TODO: Print the area of each shape
void PrintArea(Shape2D shape) {
    Console.WriteLine($"{shape.GetArea()}");
}

// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class.
PrintArea(c);
PrintArea(r);
PrintArea(s);
