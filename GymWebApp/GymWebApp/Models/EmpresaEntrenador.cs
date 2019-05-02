using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class EmpresaEntrenador
    {
        [Key, Column(Order = 1), ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }
        [Key, Column(Order = 2), ForeignKey("Entrenador")]
        public int IdEntrenador { get; set; }
        

        public virtual Empresa Empresa { get; set; }
        public virtual Entrenador Entrenador { get; set; }
    }
}