namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBBOLETA")]
    public partial class TBBOLETA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBBOLETA()
        {
            TBDETBOLETAs = new HashSet<TBDETBOLETA>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string Serie { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaEmision { get; set; }

        [StringLength(11)]
        public string Ruc { get; set; }

        [StringLength(3)]
        public string Sucursal { get; set; }

        [StringLength(8)]
        public string CodigoEmp { get; set; }

        [StringLength(40)]
        public string NombreEmp { get; set; }

        [StringLength(8)]
        public string DniCli { get; set; }

        [StringLength(40)]
        public string NombreCli { get; set; }

        public decimal? Total { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBDETBOLETA> TBDETBOLETAs { get; set; }

        public virtual TBEMPRESA TBEMPRESA { get; set; }

        public virtual TBCLIENTE TBCLIENTE { get; set; }
    }
}
