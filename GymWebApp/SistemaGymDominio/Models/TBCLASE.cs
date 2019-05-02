namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBCLASE")]
    public partial class TBCLASE
    {
        [StringLength(30)]
        public string NombreClase { get; set; }

        [StringLength(8)]
        public string Entrenador { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string Sucursal { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Dia { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string Horario { get; set; }

        public virtual TBENTRENADOR TBENTRENADOR { get; set; }
    }
}
