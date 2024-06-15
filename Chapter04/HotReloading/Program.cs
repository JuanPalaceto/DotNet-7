/* Visual Studio: run the app, change the message, click Hot Reload 
button.
 * Visual Studio Code: run the app using dotnet watch, change the 
message. */

while (true)
{
    WriteLine("Hello, Hot Reload!"); // Cambiado en ejecución
    // WriteLine("Goodbye, Hot Reload!"); // Vuelto a cambiar al cambiar a "Recarga activa al guardar"
    await Task.Delay(2000);
}