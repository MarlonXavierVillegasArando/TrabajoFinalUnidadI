using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymWebApp.Models
{
    public class Cliente
    {
        public int  Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string NomPlan { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }

    }
}