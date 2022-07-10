char a;
Console.Write("Input an uppercase character: ");
a = char.Parse(Console.ReadLine());
a = (char) (a + 32);
Console.WriteLine("The lowercase equivalent is '" + a + "'.");