WriteLine();
WriteLine("***** EXCEPCIONES OVERFLOW CON LA SENTANCIA CHECKED *****");

try
{
	checked
	{
		int x = int.MaxValue - 1;
		WriteLine($"Initial value: {x}");
		x++;
		WriteLine($"After incrementing: {x}");
		x++;
		WriteLine($"After incrementing: {x}");
		x++;
		WriteLine($"After incrementing: {x}");
		x++;
	}
}
catch (OverflowException)
{
	WriteLine("The code overflowed but I caught the exception.");
}

WriteLine();
WriteLine("***** UNCHECKED *****");
unchecked
{
	int y = int.MaxValue + 1;
	WriteLine($"Initial value: {y}");
	y--;
	WriteLine($"After decrementing: {y}");
	y--;
	WriteLine($"After decrementing: {y}"); 
}