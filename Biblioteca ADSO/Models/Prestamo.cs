using System;
using System.Collections.Generic;

namespace Biblioteca_ADSO.Models;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public int? IdLibro { get; set; }

    public int? IdUsuario { get; set; }

    public DateOnly FechaPrestamo { get; set; }

    public DateOnly? FechaDevolucion { get; set; }

    public string EstadoPrestamo { get; set; } = null!;

    public virtual Libro? IdLibroNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
