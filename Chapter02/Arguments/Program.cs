// Console es importado en el proyecto con
// <ItemGroup>
//  < Using Include = "System.Console" Static = "true" />
// </ ItemGroup >


WriteLine($"There are {args.Length} arguments");

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}
ForegroundColor = (ConsoleColor)Enum.Parse( // Actualiza el color de la letra de la consola
enumType: typeof(ConsoleColor),
value: args[0],
ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse( // El color de su bg
enumType: typeof(ConsoleColor),
value: args[1], // con esto se recuperan los parametros seteados en Proyecto > Propiedades de Arguments > Depurar > abrir UI...
ignoreCase: true);
//CursorSize = int.Parse(args[2]);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
}