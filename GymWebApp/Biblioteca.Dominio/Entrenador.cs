using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    public class Entrenador
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CodSucursal { get; set; }
        public string Estado { get; set; }
        
        public TeachingMode ModeOfTeaching { get; set; }
    }

    public enum TeachingMode
    {
        Online,
        ClassRoom,
        LiveOnline
    }
}
