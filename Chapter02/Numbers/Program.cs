// Solo valores positivos enteros (De 0 a 4294967295)
uint naturalNumber = 23;

// Solo valores enteros, puede incluir negativos (De -2147483648 a 2147483647)
int integerNumber = -23;

// Valores reales, debe llevar la letra F
float realNumber = 2.3F;

// double es el tipo por defecto para valores decimales
double anotherRealNumber = 2.3;

// Tres formas de declarar una variable ocn el valor de 2000000
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// compara que tengan el mismo valor
// ambas comparaciones imprimen true
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");


/* Explorando el tamaño de los números */
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if ( a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals:");
decimal c = 0.1M; // Se deben poner con la M los decimales
decimal d = 0.2M;
if ( c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3}");
}