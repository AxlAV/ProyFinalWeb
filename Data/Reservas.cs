using System;
using System.Collections.Generic;

namespace ProyFinalWeb.Data;

public partial class Reservas
{
    public int ReservaId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ActividadId { get; set; }

    public DateTime? FechaReserva { get; set; }

    public int? CantidadPersonas { get; set; }

    public string? Estado { get; set; }

    public virtual Actividades? Actividad { get; set; }

    public virtual Usuarios? Usuario { get; set; }
}
