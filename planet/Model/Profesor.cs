namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profesor")]
    public partial class Profesor
    {
        [Key]
        public int pk_profesor { get; set; }

        public int rol { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string clave { get; set; }

        public int activo { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        [Required]
        [StringLength(35)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime? anioIngreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? anioEgreso { get; set; }

        [Required]
        [StringLength(20)]
        public string telefono { get; set; }

        [StringLength(20)]
        public string celular { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
