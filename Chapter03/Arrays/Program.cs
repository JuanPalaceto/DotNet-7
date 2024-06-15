/* ARRAYS DE UNA DIMENSIÓN */
using System;

string[] names; // Puede tomar cualquier longitud de elementos

names = new string[4]; // Separar la memoria que tomará, en este caso 5 elementos

// Otra forma de declarar e inicializar un array en una línea
string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };

// Guardar los elementso en sus posiciones
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// Iterar sobre names
for (int i = 0; i < names.Length; i++)
{
    //WriteLine(names[i]);
    WriteLine(names2[i]); // mismo resultado 
}

/* ARRAYS DE 2 DIMENSIÓN */
string[,] grid1 = new[,] // 2 dimensiones
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Beck", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" },
};

// Lower y Upper bounds (Longitudes de cada dimensión)
WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}"); // 0
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}"); // 2
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}"); // 0
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}"); // 3

// Usar esos bounds para iterar sobre el array
for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}

// Otra forma de hacerlo
// alternative syntax
string[,] grid2 = new string[3, 4]; // allocate memory
grid2[0, 0] = "Alpha"; // assign values
grid2[0, 1] = "Beta";
// and so on
grid2[2, 3] = "Dog";

/* JAGGED ARRAYS (MULTIDIMENSIONALES, PERO DE DIFERENTE DIMENSIONES, ES DEICR, UNA FILA PUEDE TENER 3 COLUMNAS Y OTRA 4...) */
WriteLine();
WriteLine("***** JAGGED ARRAYS *****");
string[][] jagged = new[] // array of string arrays
{
    new [] { "Alpha", "Beta", "Gamma" },
    new [] { "Anne", "Ben", "Charlie", "Doug" },
    new [] { "Aardvark", "Bear" }
};

// Obtener el índice mayor -> 2
WriteLine("Upper bound of array of arrays is: {0}",
    jagged.GetUpperBound(0));

// Obtener el índice mayor de cada array ->
// 2
// 3
// 1
for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine("Upper bound of array {0} is {1}",
        arg0: array,
        arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++) // Obtener el índice mayor del array principal, que contiene los otros arrays
{
    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++) // Obtener el índice mayor de cada fila = array
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }
}

/* LIST PATTERN MATCHING */
WriteLine();
WriteLine("***** LIST PATTERN MATCHING *****");

int[] sequentialNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = new int[] { 1, 2 };
int[] oneTwoTenNumbers = new int[] { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 10 };
int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 9, 7, 5 };
int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10 };
WriteLine($"{nameof(sequentialNumbers)}: { CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: { CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: { CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: { CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");
static string CheckSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
    [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
    [1, 2] => "Contains 1 then 2.",
    [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any range of numbers.",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.",
};