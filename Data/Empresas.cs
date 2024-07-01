using System;
using System.Collections.Generic;

namespace ProyFinalWeb.Data;

public partial class Empresas
{
    public int EmpresaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public byte[]? ImagenEmpresa { get; set; }

    public virtual ICollection<Actividades> Actividades { get; set; } = new List<Actividades>();
}
