namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mensajes
    {
        [Key]
        public int pk_mensaje { get; set; }

        public int fk_alumno { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(20)]
        public string hora { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string descripcion { get; set; }

        public virtual Alumnos Alumnos { get; set; }
    }
}
