using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class ClienteEntrenador
    {
        [Key, Column(Order = 1), ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [Key, Column(Order = 2), ForeignKey("Entrenador")]
        public int IdEntrenador { get; set; }

        public string Sucursal { get; set; }
        public string Plan { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Entrenador Entrenador { get; set; }
    }
}