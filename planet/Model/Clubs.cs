namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clubs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clubs()
        {
            RegistroClubs = new HashSet<RegistroClubs>();
        }

        [Key]
        public int pk_club { get; set; }

        [Required]
        [StringLength(50)]
        public string titulo { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

        public int estado { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public int fk_hora { get; set; }

        public int fk_profesor { get; set; }

        public int cupo { get; set; }

        public int fk_tipoClub { get; set; }

        public int? id_registro { get; set; }

        public virtual cat_Horarios cat_Horarios { get; set; }

        public virtual TipoClub TipoClub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroClubs> RegistroClubs { get; set; }
    }
}
