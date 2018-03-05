namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cat_EstadoGenerico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pk_estadoGenerico { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }
    }
}
