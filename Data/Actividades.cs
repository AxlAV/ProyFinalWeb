using System;
using System.Collections.Generic;

namespace ProyFinalWeb.Data;

public partial class Actividades
{
    public int ActividadId { get; set; }

    public int? EmpresaId { get; set; }

    public string Titulo { get; set; } = null!;

    public string? DescripcionLarga { get; set; }

    public string? DescripcionPequeña { get; set; }

    public string? Itinerario { get; set; }

    public string? Destino { get; set; }

    public DateOnly? Fecha { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraFin { get; set; }

    public decimal? Precio { get; set; }

    public int? Capacidad { get; set; }

    public byte[]? ImagenActividad { get; set; }

    public virtual Empresas? Empresa { get; set; }

    public virtual ICollection<EstadisticasActividades> EstadisticasActividades { get; set; } = new List<EstadisticasActividades>();

    public virtual ICollection<Reservas> Reservas { get; set; } = new List<Reservas>();

    public virtual ICollection<Reseñas> Reseñas { get; set; } = new List<Reseñas>();
}
