namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBDETBOLETA")]
    public partial class TBDETBOLETA
    {
        [Key]
        public int iddet { get; set; }

        [Required]
        [StringLength(3)]
        public string Serie { get; set; }

        [Required]
        [StringLength(6)]
        public string Numero { get; set; }

        [StringLength(3)]
        public string CodigoPlan { get; set; }

        [StringLength(30)]
        public string NombrePlan { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Importe { get; set; }

        public virtual TBBOLETA TBBOLETA { get; set; }

        public virtual TBPLAN TBPLAN { get; set; }
    }
}
