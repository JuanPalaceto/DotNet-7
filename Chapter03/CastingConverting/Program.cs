using static System.Convert; // ToInt32()

int a = 10;
double b = a; // Un int se puede castear a un double sin problema
WriteLine(b);

double c = 9.8;
//int d = c; // Error de compilación
int d = (int)c; // d pierde el decimal .8
WriteLine(d);

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = long.MaxValue;
//e = 5_000_000_000; // el valor de int pasa a ser 705,032,704, es decir, no se comporta como se espera
f = (int)e; // Se desborda el valor y se pone como -1, ya que int no puede tener tantos valores como long
WriteLine($"e is {e:N0} and f is {f:N0}");

/* System.Convert */
WriteLine();
WriteLine("***** CONVERTIR CON System.Convert *****");
double g = 9.8;
int h = ToInt32(g); // Redondea el decimal en vez de recortarlo o 'trimearlo'
WriteLine($"g is {g} and h is {h}");

double[] doubles = new[]
{
    9.49, 9.5, 9.51, 10.49, 10.5, 10.51
};

WriteLine();
WriteLine("Banker's rounding");
foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

WriteLine();
WriteLine("Rounding away from zero");

foreach (double n in doubles)
{
    WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0,
                mode: MidpointRounding.AwayFromZero));
}

WriteLine();
WriteLine("CONVERTIR CUALQUIER TIPO A STRING");
int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());

WriteLine();
WriteLine("CONVERTIR OBJETO BINARIO A STRING");
byte[] binaryObject = new byte[128];
Random.Shared.NextBytes(binaryObject); // Llenar un array con bytes random
WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X} "); // :X formatea a notación decimal
}
WriteLine();

// Convertir a Base64 string
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

WriteLine();
WriteLine("CONVERTIR DE STRINGS A NUMEROS Y FECHAS O TIEMPOS");
int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}."); // :D solamente la fecha

// int count = int.Parse("abc"); // Format exception

WriteLine();
WriteLine("TRY PARSE");
Write("How many eggs are there? ");
string? input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}