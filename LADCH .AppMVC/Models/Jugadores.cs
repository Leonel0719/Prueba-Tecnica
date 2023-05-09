using System;
using System.Collections.Generic;

namespace LADCH_.AppMVC.Models;

public partial class Jugadores
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Posicion { get; set; } = null!;

    public int Dorsal { get; set; }
}
