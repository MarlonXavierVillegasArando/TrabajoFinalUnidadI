using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class ClaseEntrenador
    {
        [Key, Column(Order = 1), ForeignKey("Clase")]
        public int IdCliente { get; set; }
        [Key, Column(Order = 2), ForeignKey("Entrenador")]
        public int IdEntrenador { get; set; }
        

        public virtual Clases Clase { get; set; }
        public virtual Entrenador Entrenador { get; set; }
    }
}