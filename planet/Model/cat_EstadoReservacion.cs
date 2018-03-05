namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cat_EstadoReservacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cat_EstadoReservacion()
        {
            RegistroCitas = new HashSet<RegistroCitas>();
            RegistroClubs = new HashSet<RegistroClubs>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pk_estadoReservacion { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroCitas> RegistroCitas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroClubs> RegistroClubs { get; set; }
    }
}
