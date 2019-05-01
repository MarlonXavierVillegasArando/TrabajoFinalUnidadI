using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class Clases
    {
        [Key, Column(Order = 1), ForeignKey("Entrenador")]
        public int IdEntrenador { get; set; }
        public string NombreClase { get; set; }
        public string Entrenador { get; set; }
        public string Sucursal { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public virtual Entrenador vEntrenador { get;  set; }
       
    }
}