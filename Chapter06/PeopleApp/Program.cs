using Packt.Shared;
using PacktLibrary;

Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};

harry.WriteToConsole();

WriteLine();
WriteLine("******* non-generic lookup collection *******");

// non-generic lookup collection
System.Collections.Hashtable lookUpObject = new();
lookUpObject.Add(key: 1, value: "Alpha");
lookUpObject.Add(key: 2, value: "Beta");
lookUpObject.Add(key: 3, value: "Gamma");
lookUpObject.Add(key: harry, value: "Delta");

int key = 2; // look up the value that has 2 as its key

WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookUpObject[key]);

// look up the value that has harry as its key
WriteLine(format: "Key {0} has value: {1}",
    arg0: harry,
    arg1: lookUpObject[harry]);

WriteLine();
WriteLine("******* generic types *******");

// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
//lookupIntString.Add(key: harry, value: "Delta"); // error de compilacion
lookupIntString.Add(key: 4, value: "Delta");

key = 3;

WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupIntString[key]);

// Delegados
WriteLine();
WriteLine("******* delegates *******");

// assign a method to the Shout delegate
//harry.Shout = Harry_Shout; // error porque ahora uso la palabra event en la propiedad Shout de Person
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;

// call the Poke method that raises the Shout event
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

WriteLine();
WriteLine("******* interfaces *******");

Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

OutputPeopleNames(people, "Initial list of people:");

Array.Sort(people);

OutputPeopleNames(people,
    "After sorting using Person's IComparable implementation:");

WriteLine();
WriteLine("******* comparer en vez de comparable *******");

Array.Sort(people, new PersonComparer()); // usando el metodo sobrecargado que utiliza un comparer
OutputPeopleNames(people,
    "After sorting using PersonComparer's IComparar implementation:");

// Tipos de memoria
WriteLine();
WriteLine("******* Stack & heap *******");

Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1 == p2 {(p1 == p2)}");

Person p3 = p1;
WriteLine($"P3: {p3}");
WriteLine($"p1 == p3 {p1 == p3}");

WriteLine(($"p1.Name: {p1.Name}, p2.Name: {p2.Name}"));
WriteLine($"p1.Name == p2.Name: {(p1.Name == p2.Name)}");


WriteLine();
WriteLine("******* struct types *******");
DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;

WriteLine($"({dv1.X}, {dv1.Y}), + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

DisplacementVector dv4 = new();
WriteLine($"({dv4.X}, {dv4.Y})");

// Tip: si mi tipo no supera los 16 bytes de almacenamiento, es más recomendable utilizar structs


WriteLine();
WriteLine("******* Inheriting from classes *******");

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};
john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

WriteLine(john.ToString());

Employee aliceInEmployee = new()
{ Name = "Alice", EmployeeCode = "AA123" };
Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());

if (aliceInPerson is Employee)
{
    WriteLine($"{nameof(aliceInPerson)} IS an Employee");

    Employee explicitAlice = (Employee)aliceInPerson; 

    // safely do something with explicitAlice
}

// as keyword to cast. Regresa null si no se puede castear en vez de una excepcion

Employee? aliceAsEmployee = aliceInPerson as Employee; // could be null

if (aliceAsEmployee is not null)
{
    WriteLine($"{nameof(aliceInPerson)} AS an Employee");

    // safely do something with aliceAsEmployee
}


WriteLine();
WriteLine("******* Exceptions *******");

try
{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 25));
}
catch (PersonException ex)
{
    WriteLine(ex.Message);
}


WriteLine();
WriteLine("******* extension methods *******");

string email1 = "pamela@test.com";
string email2 = "ian&test.com";

WriteLine("{0} is a valid e-mail address: {1}",
    arg0: email1,
    arg1: email1.IsValidEmail());

WriteLine("{0} is a valid e-mail address: {1}",
    arg0: email2,
    arg1: email2.IsValidEmail());