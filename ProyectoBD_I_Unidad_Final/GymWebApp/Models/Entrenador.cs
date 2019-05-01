using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class Entrenador
    {

        [Key, Column(Order = 1), ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CodSucursal { get; set; }
        public string Estado { get; set; }
        public  virtual Empresa Empresa { get; set; }
    

    }
}