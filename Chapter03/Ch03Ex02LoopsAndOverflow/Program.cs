// Loop infinito ya que byte solo llega a 256 y se reinicia, entonces nunca es 500
// Con un checked se resolvería

int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}

// Ejemplo del libro completo
checked
{
    try
    {
        int max2 = 500;
        for (byte i = 0; i < max2; i++)
        {
            WriteLine(i);
        }
    }
    catch (OverflowException ex)
    {
        WriteLine($"{ex.GetType()} says {ex.Message}");
    }
}