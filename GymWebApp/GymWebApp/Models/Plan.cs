using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymWebApp.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public int Duracion { get; set; }
        public string Estado { get; set; }
    }
}