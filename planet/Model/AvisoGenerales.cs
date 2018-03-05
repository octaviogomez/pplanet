namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AvisoGenerales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pk_avisosGenerales { get; set; }

        [Column(TypeName = "text")]
        public string Descripcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [Column(TypeName = "text")]
        public string Direccion { get; set; }
    }
}
