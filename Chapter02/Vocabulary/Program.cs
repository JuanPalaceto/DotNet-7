using System.Reflection;

// declarar algunas variables usando Tipos en ensamblados adicionales
// De este modo se cargan en nuestra app y podemos ver sus metodos
System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return; // termina la app

// Iterar sobre los ensamblados a los que hace referencia mi app
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Carga el ensamblado para leer sus detalles
    Assembly a = Assembly.Load(name);

    // declarar una variable para contar el número de metódos
    int methodCount = 0;

    // Iterar sobre todos los Tipos en el ensamblado
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Agregar al contador de metodos
        methodCount += t.GetMethods().Count();
    }

    // Imprimir el conteo de Tipos y sus metodos
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.", // N0 formatea la cadena a un número con cero decimales.
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}

// Ver la versión del compilador y de lenguaje
//#error version