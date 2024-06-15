// Mi solución
int top = 100;
string[] fizz = new string[100];

for (int i = 1; i <= top; i++)
{
	int index = i - 1;

	if (i % 3 == 0 && i % 5 == 0)
	{
		fizz[index] = "FizzBuzz";
	}
	else if (i % 3 == 0)
	{
        fizz[index] = "Fizz";
    }
	else if (i % 5 == 0)
	{
        fizz[index] = "Buzz";
    }
	else
	{
        fizz[index] = i.ToString();
    }
}

WriteLine(string.Join(", ", fizz));

// Ejemplo del libro
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Write("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Write("Buzz");
    }
    else if (i % 3 == 0)
    {
        Write("Fizz");
    }
    else
    {
        Write(i);
    }

    // put a comma and space after every number except 100
    if (i < 100) Write(", ");

    // write a carriage-return after every ten numbers
    if (i % 10 == 0) WriteLine();
}
WriteLine();