// Ver -> Salida -> Mostrar salida de: Depurar

// Cambiar la configuración a Release

using System.Diagnostics;
using Microsoft.Extensions.Configuration;
/* ! Hay que instalar los paquetes de NuGet  */
//Microsoft.Extensions.Configuration
//Microsoft.Extensions.Configuration.Binder
//Microsoft.Extensions.Configuration.FileExtensions
//Microsoft.Extensions.Configuration.Json

// Click derecho sobre appsettings.json y cambiar a copiar si es posterior

// Logear en un archivo .txt en el escritorio
string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

// text writer is buffered, so this option calls
// Flush() on all listeners after writing
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

// Crear un builder que busque en la carpeta actual el nuevo archivo appsettins.json, construya la confiuración, cree un switch trace, establezca su nivel e imprimna los 4 niveles
Console.WriteLine("Reading from appsettings.json in {0}",
 arg0: Directory.GetCurrentDirectory());

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(
 displayName: "PacktSwitch",
 description: "This switch is set via a JSON config.");

#region EsteCodigoNoFuncionó
//configuration.GetSection("PacktSwitch").Bind(ts);

//Trace.WriteLineIf(ts.TraceError, "Trace error");
//Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
//Trace.WriteLineIf(ts.TraceInfo, "Trace information");
//Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

//Console.ReadLine(); 
#endregion

// Leer la sección "PacktSwitch" del archivo appsettings.json
var packtSwitchSection = configuration.GetSection("PacktSwitch");

// Obtener el valor de cadena del nivel de traza desde la sección
var traceLevelString = packtSwitchSection["Level"];

// Convertir la cadena a un valor de enumeración TraceLevel
if (Enum.TryParse(traceLevelString, true, out TraceLevel traceLevel))
{
    // Establecer el nivel de traza en el TraceSwitch
    ts.Level = traceLevel;
}
else
{
    // Manejar el caso en que el nivel de traza no se pueda convertir
    Console.WriteLine($"Error: Invalid trace level '{traceLevelString}' specified in appsettings.json");
}

// Imprimir los niveles de traza
Console.WriteLine($"Trace Level: {ts.Level}");
Console.WriteLine($"Error: {ts.TraceError}");
Console.WriteLine($"Warning: {ts.TraceWarning}");
Console.WriteLine($"Info: {ts.TraceInfo}");
Console.WriteLine($"Verbose: {ts.TraceVerbose}");

// Ejemplo de cómo usar el TraceSwitch
if (ts.TraceInfo)
{
    Console.WriteLine("This is an informational message.");
}

if (ts.TraceWarning)
{
    Console.WriteLine("This is a warning message.");
}

if (ts.TraceError)
{
    Console.WriteLine("This is an error message.");
}

if (ts.TraceVerbose)
{
    Console.WriteLine("This is a verbose message.");
}

Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

// Mantener la consola abierta hasta que se presione una tecla
Console.ReadLine();
