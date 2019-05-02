namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBPLAN")]
    public partial class TBPLAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBPLAN()
        {
            TBDETBOLETAs = new HashSet<TBDETBOLETA>();
        }

        [Key]
        [StringLength(3)]
        public string Codigo { get; set; }

        [StringLength(30)]
        public string Nombre { get; set; }

        public decimal? Costo { get; set; }

        public int? Duracion { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBDETBOLETA> TBDETBOLETAs { get; set; }
    }
}
