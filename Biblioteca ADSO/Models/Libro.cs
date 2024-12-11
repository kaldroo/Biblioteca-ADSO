using System;
using System.Collections.Generic;

namespace Biblioteca_ADSO.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Editorial { get; set; } = null!;

    public int AnoPublicacion { get; set; }

    public string Isbn { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
