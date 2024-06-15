int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

// Interesante forma de usar un while en base a un input
// Comentado para que no interfiera con el flujo programa
//string? actualPassword = "Pa$$w0rd";
//string? password;
//int maximumAttempts = 10;
//int attempts = 0;

//do
//{
//    attempts++;
//    Write("Enter your password: ");
//    password = ReadLine();
//}
//while ((password != actualPassword) & (attempts < maximumAttempts));

//if (password == actualPassword)
//{
//    WriteLine("Correct!");
//}
//else
//{
//    WriteLine("You have used {0} attempts! The password was {1}.",
//      arg0: maximumAttempts, arg1: actualPassword);
//}

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

// Uso de foreach
string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}