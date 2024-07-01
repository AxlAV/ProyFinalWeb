using System;
using System.Collections.Generic;

namespace ProyFinalWeb.Data;

public partial class EstadisticasActividades
{
    public int EstadisticaId { get; set; }

    public int? ActividadId { get; set; }

    public int? TotalReservas { get; set; }

    public decimal? PromedioValoracion { get; set; }

    public virtual Actividades? Actividad { get; set; }
}
