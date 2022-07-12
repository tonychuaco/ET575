float a, b;
int c;
Console.Write("Enter a floating-point value: ");
a = float.Parse(Console.ReadLine());
Console.Write("Enter a floating-point value: ");
b = float.Parse(Console.ReadLine());
c = (int) (a + b);
Console.Write("Sum of the integers: " + c);