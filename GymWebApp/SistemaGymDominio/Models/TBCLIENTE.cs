namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBCLIENTE")]
    public partial class TBCLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBCLIENTE()
        {
            TBBOLETAs = new HashSet<TBBOLETA>();
        }

        [Key]
        [StringLength(8)]
        public string Dni { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(40)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(9)]
        public string telefono { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(10)]
        public string Genero { get; set; }

        [StringLength(30)]
        public string NomPlan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaTermino { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBBOLETA> TBBOLETAs { get; set; }
    }
}
