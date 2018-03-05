namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListaEspera")]
    public partial class ListaEspera
    {
        [Key]
        public int pk_listaEspera { get; set; }

        public int fk_alumno { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(20)]
        public string hora { get; set; }

        public int? fk_club { get; set; }

        public int? fk_cita { get; set; }

        public virtual Alumnos Alumnos { get; set; }

        public virtual RegistroCitas RegistroCitas { get; set; }

        public virtual RegistroClubs RegistroClubs { get; set; }
    }
}
