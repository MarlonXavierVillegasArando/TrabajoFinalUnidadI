namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBENTRENADOR")]
    public partial class TBENTRENADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBENTRENADOR()
        {
            TBCLASEs = new HashSet<TBCLASE>();
        }

        [Key]
        [StringLength(8)]
        public string Dni { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(40)]
        public string Apellido { get; set; }

        [StringLength(40)]
        public string Direccion { get; set; }

        [StringLength(40)]
        public string Telefono { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(3)]
        public string CodSucursal { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBCLASE> TBCLASEs { get; set; }

        public virtual TBEMPRESA TBEMPRESA { get; set; }
    }
}
