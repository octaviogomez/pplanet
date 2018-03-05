namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistroCitas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistroCitas()
        {
            ListaEspera = new HashSet<ListaEspera>();
        }

        [Key]
        public int pk_registroCita { get; set; }

        public int fk_cita { get; set; }

        public int fk_alumno { get; set; }

        public int fk_tipoCitas { get; set; }

        public int estadoReservacion { get; set; }

        public int? fk_lecciones { get; set; }

        public virtual Alumnos Alumnos { get; set; }

        public virtual cat_EstadoReservacion cat_EstadoReservacion { get; set; }

        public virtual cat_lecciones cat_lecciones { get; set; }

        public virtual cat_TipoCitas cat_TipoCitas { get; set; }

        public virtual Citas Citas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaEspera> ListaEspera { get; set; }
    }
}
