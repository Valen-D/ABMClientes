using System;
using System.Collections.Generic;

namespace ABMClientes.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime? FechaDeNacimiento { get; set; }

    public string Cuit { get; set; } = null!;

    public string? Domicilio { get; set; }

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;
}
