using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    class Clase
    {
        public string NombreClase { get; set; }
        public string Entrenador { get; set; }
        public string Sucursal { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public virtual Entrenador ClaseAsignada { get; private set; }
    }
}
