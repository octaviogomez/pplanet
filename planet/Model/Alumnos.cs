namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alumnos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumnos()
        {
            BuzonSugerencias = new HashSet<BuzonSugerencias>();
            ListaEspera = new HashSet<ListaEspera>();
            Mensajes = new HashSet<Mensajes>();
            RegistroCitas = new HashSet<RegistroCitas>();
            RegistroClubs = new HashSet<RegistroClubs>();
        }

        [Key]
        public int pk_alumno { get; set; }

        public int rol { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string clave { get; set; }

        public int activo { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        [Required]
        [StringLength(20)]
        public string nombre { get; set; }

        [Required]
        [StringLength(35)]
        public string apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime? anioIngreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? anioEgreso { get; set; }

        public int? estadoPago { get; set; }

        [StringLength(50)]
        public string facebook { get; set; }

        [StringLength(30)]
        public string telefono { get; set; }

        [StringLength(30)]
        public string celular { get; set; }

        [StringLength(2)]
        public string sexo { get; set; }

        public int? edad { get; set; }

        public int nivel { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        public int? noClubs { get; set; }

        public int? noPelis { get; set; }

        public virtual cat_EstatusPago cat_EstatusPago { get; set; }

        public virtual cat_NivelIngles cat_NivelIngles { get; set; }

        public virtual Roles Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuzonSugerencias> BuzonSugerencias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaEspera> ListaEspera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensajes> Mensajes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroCitas> RegistroCitas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroClubs> RegistroClubs { get; set; }
    }
}
