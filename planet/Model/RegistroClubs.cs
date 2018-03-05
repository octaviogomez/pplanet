namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistroClubs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistroClubs()
        {
            ListaEspera = new HashSet<ListaEspera>();
        }

        [Key]
        public int pk_registroClub { get; set; }

        public int fk_club { get; set; }

        public int fk_alumno { get; set; }

        public int estadoReservacion { get; set; }

        public virtual Alumnos Alumnos { get; set; }

        public virtual cat_EstadoReservacion cat_EstadoReservacion { get; set; }

        public virtual Clubs Clubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaEspera> ListaEspera { get; set; }
    }
}
