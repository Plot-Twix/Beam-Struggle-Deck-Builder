using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum AtributosSecundarios : uint
{
    None = 0,
    Humano = 1 << 0,
    Extraterrestre = 1 << 1,
    Metálico = 1 << 2,
    Besta = 1 << 3
}

