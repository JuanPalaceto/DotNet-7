using System.Xml;

object height = 1.88; // guardando un double en un objeto
object name = "Amir"; // guardando un string en un objeto
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length; // error de compilación
int lenght2 = ((string)name).Length; // le dice al compilador que es un string
Console.WriteLine($"{name} has {lenght2} characters.");

// Tipos dinamicos
// Son objetos, pero dinamicos, no necesitan hacer el cast para invocar sus metodos * El performance es el costo
// Ejemplo de guardar un string en un obj dinamico
dynamic something = "Ahmed";

// int no tiene una propiedad Lenght
something = 12;

// Los arrays sí tienen esta prop
something = new[] { 3, 5, 7 };

// Esto compila, pero daría un error si despues yo le doy un valor que no tenga una propiedad Length (como un int)
Console.WriteLine($"Length is {something.Length}");


/* Declarando variables locales */
var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false

// Buen uso porque se evitar repetir el tipo la segunda vez
// Usar solamente cuando no tenga opción, esto es cuando estoy creando un tipo anónimo, por ejemplo
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// mal uso porque aquí no sabemos directamente que tipo será
var file1 = File.CreateText("something.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// target-typed new to instantiate objects C# 9
XmlDocument xml3 = new();

Person kim = new();
kim.BirthDate = new(1967, 12, 26); // En vez de new DateTime(1967, 12, 26)

List<Person> list = new List<Person>()
{
    new() { FirstName = "Alice" },
    new() { FirstName = "Bob" },
    new() { FirstName = "Charlie" },
};

/* Explorando los valores default */
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

class Person
{
    public DateTime BirthDate;
    public string FirstName = "";
}