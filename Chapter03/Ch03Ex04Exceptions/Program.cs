try
{
    WriteLine("Enter a number between 0 and 255: ");
    byte num = byte.Parse(ReadLine()!);
    WriteLine("Enter another number between 0 and 255: ");
    byte num2 = byte.Parse(ReadLine()!);

    int division = num / num2;
    WriteLine($"{num} divided by {num2} is {division}");
}
catch (OverflowException ofe)
{
    WriteLine(ofe.Message);
}
catch (FormatException fe)
{
    WriteLine(fe.Message);
}

// Solucion de libro
Write("Enter a number between 0 and 255: ");
string n1 = ReadLine()!;

Write("Enter another number between 0 and 255: ");
string n2 = ReadLine()!;

try
{
    byte a = byte.Parse(n1);
    byte b = byte.Parse(n2);

    int answer = a / b;

    WriteLine($"{a} divided by {b} is {answer}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}