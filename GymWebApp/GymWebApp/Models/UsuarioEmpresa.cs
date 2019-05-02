using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class UsuarioEmpresa
    {
        [Key, Column(Order = 1), ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        [Key, Column(Order = 2), ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }
        

        public virtual Usuario Usuario { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}