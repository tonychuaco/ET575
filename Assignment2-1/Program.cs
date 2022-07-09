string first, last, name;
first = "John";
last = "Smith";
name = first + " " + last;
Console.WriteLine("Name: " + name);
Console.WriteLine("Length: " + name.Length);
name = name.Insert(4, " H");
Console.WriteLine("Name: " + name);
Console.WriteLine("Initials: " + name.ElementAt(0) + ". " + name.ElementAt(5) + ". " + name.ElementAt(7) + ".");
