using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

[Flags] // Para poder regresar multiples valores en un string separados por coma en vez de uno solo int
public enum WondersOfTheAncientWorld : byte // reducimos de 4 bytes por un int a 1 byte
    // byte para 8 opciones
    // ushort para 16 opciones
    // uint para 32 opciones
    // ulong para 64 opciones
{
    None                        = 0b_0000_0000, // i.e. 0
    GreatPyramidOfGiza          = 0b_0000_0001, // i.e. 1
    HangingGardensOfBabylon     = 0b_0000_0010, // i.e. 2
    StatueOfZeusAtOlympia       = 0b_0000_0100, // i.e. 4
    TempleOfArtemisAtEphesus    = 0b_0000_1000, // i.e. 8
    MausoleumAtHalicarnassus    = 0b_0001_0000, // i.e. 16
    ColossusOfRhodes            = 0b_0010_0000, // i.e. 32
    LighthouseOfAlexandria      = 0b_0100_0000, // i.e. 64
}
