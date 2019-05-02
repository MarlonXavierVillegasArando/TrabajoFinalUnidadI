namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBUSUARIO")]
    public partial class TBUSUARIO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Codigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Dni { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(40)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(9)]
        public string Telefono { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(15)]
        public string Cargo { get; set; }

        [StringLength(8)]
        public string Clave { get; set; }

        [StringLength(6)]
        public string Turno { get; set; }

        [StringLength(3)]
        public string CodigoSucursal { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }
    }
}
