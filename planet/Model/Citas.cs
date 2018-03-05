namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Citas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Citas()
        {
            RegistroCitas = new HashSet<RegistroCitas>();
        }

        [Key]
        public int pk_cita { get; set; }

        public int estado { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public int fk_hora { get; set; }

        public int? cupo { get; set; }

        public int NoProfes { get; set; }

        public int? id_registro { get; set; }

        public virtual cat_Horarios cat_Horarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroCitas> RegistroCitas { get; set; }
    }
}
