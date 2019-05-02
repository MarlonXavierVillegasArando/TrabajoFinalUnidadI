using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymWebApp.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


    }
}