char a;
int n;
Console.Write("Input an uppercase character: ");
a = char.Parse(Console.ReadLine());
n = a + 32;
a = (char) n;
Console.WriteLine("The lowercase equivalent is '" + a + "'.");