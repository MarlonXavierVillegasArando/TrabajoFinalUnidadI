namespace SistemaGymDominio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBEMPRESA")]
    public partial class TBEMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBEMPRESA()
        {
            TBBOLETAs = new HashSet<TBBOLETA>();
            TBENTRENADORs = new HashSet<TBENTRENADOR>();
        }

        [Key]
        [StringLength(3)]
        public string Codigo { get; set; }

        [StringLength(11)]
        public string Ruc { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(6)]
        public string Telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBBOLETA> TBBOLETAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBENTRENADOR> TBENTRENADORs { get; set; }
    }
}
