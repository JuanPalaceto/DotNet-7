using System;
using System.Collections.Generic;
using System.Text;

namespace PacktLibraryNetStandard2
{
    // Ejemplo de como devolver 2 valores con un tipo
    public class TextAndNumber
    {
        public string Text = null!;
        public int Number;
    }
    public class LifeTheUniverseAndEverything
    {
        public TextAndNumber GetTheData()
        {
            return new TextAndNumber
            {
                Text = "What's the meaning of life?",
                Number = 42
            };
        }
    }
}
