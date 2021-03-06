//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GolesPorJugadorEquipo
    {
        public int id { get; set; }

        [Required(ErrorMessage = "¡La cantidad de goles es obligatorio!")]
        [Range(1, 1000, ErrorMessage = "¡La cantidad de goles debe estar entre 1 y 1000!")]
        public Nullable<int> cantidadGoles { get; set; }

        [Required(ErrorMessage = "¡El nombre del equipo es obligatorio!")]
        public string equipo { get; set; }

        [Required(ErrorMessage = "¡El jugador es obligatorio!")]
        public Nullable<int> idJugador { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}
