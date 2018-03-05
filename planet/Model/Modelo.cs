namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<AvisoGenerales> AvisoGenerales { get; set; }
        public virtual DbSet<BuzonSugerencias> BuzonSugerencias { get; set; }
        public virtual DbSet<cat_EstadoGenerico> cat_EstadoGenerico { get; set; }
        public virtual DbSet<cat_EstadoReservacion> cat_EstadoReservacion { get; set; }
        public virtual DbSet<cat_EstatusPago> cat_EstatusPago { get; set; }
        public virtual DbSet<cat_Horarios> cat_Horarios { get; set; }
        public virtual DbSet<cat_lecciones> cat_lecciones { get; set; }
        public virtual DbSet<cat_NivelIngles> cat_NivelIngles { get; set; }
        public virtual DbSet<cat_TipoCitas> cat_TipoCitas { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Clubs> Clubs { get; set; }
        public virtual DbSet<ListaEspera> ListaEspera { get; set; }
        public virtual DbSet<Mensajes> Mensajes { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<RegistroCitas> RegistroCitas { get; set; }
        public virtual DbSet<RegistroClubs> RegistroClubs { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Secretaria> Secretaria { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoClub> TipoClub { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumnos>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.facebook)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .HasMany(e => e.BuzonSugerencias)
                .WithRequired(e => e.Alumnos)
                .HasForeignKey(e => e.fk_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumnos>()
                .HasMany(e => e.ListaEspera)
                .WithRequired(e => e.Alumnos)
                .HasForeignKey(e => e.fk_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumnos>()
                .HasMany(e => e.Mensajes)
                .WithRequired(e => e.Alumnos)
                .HasForeignKey(e => e.fk_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumnos>()
                .HasMany(e => e.RegistroCitas)
                .WithRequired(e => e.Alumnos)
                .HasForeignKey(e => e.fk_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumnos>()
                .HasMany(e => e.RegistroClubs)
                .WithRequired(e => e.Alumnos)
                .HasForeignKey(e => e.fk_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AvisoGenerales>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AvisoGenerales>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<BuzonSugerencias>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<BuzonSugerencias>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_EstadoGenerico>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_EstadoReservacion>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_EstadoReservacion>()
                .HasMany(e => e.RegistroCitas)
                .WithRequired(e => e.cat_EstadoReservacion)
                .HasForeignKey(e => e.estadoReservacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_EstadoReservacion>()
                .HasMany(e => e.RegistroClubs)
                .WithRequired(e => e.cat_EstadoReservacion)
                .HasForeignKey(e => e.estadoReservacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_EstatusPago>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_EstatusPago>()
                .HasMany(e => e.Alumnos)
                .WithOptional(e => e.cat_EstatusPago)
                .HasForeignKey(e => e.estadoPago);

            modelBuilder.Entity<cat_Horarios>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_Horarios>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.cat_Horarios)
                .HasForeignKey(e => e.fk_hora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_Horarios>()
                .HasMany(e => e.Clubs)
                .WithRequired(e => e.cat_Horarios)
                .HasForeignKey(e => e.fk_hora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_lecciones>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_lecciones>()
                .HasMany(e => e.RegistroCitas)
                .WithOptional(e => e.cat_lecciones)
                .HasForeignKey(e => e.fk_lecciones);

            modelBuilder.Entity<cat_NivelIngles>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_NivelIngles>()
                .HasMany(e => e.Alumnos)
                .WithRequired(e => e.cat_NivelIngles)
                .HasForeignKey(e => e.nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_TipoCitas>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cat_TipoCitas>()
                .HasMany(e => e.RegistroCitas)
                .WithRequired(e => e.cat_TipoCitas)
                .HasForeignKey(e => e.fk_tipoCitas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Citas>()
                .HasMany(e => e.RegistroCitas)
                .WithRequired(e => e.Citas)
                .HasForeignKey(e => e.fk_cita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clubs>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Clubs>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Clubs>()
                .HasMany(e => e.RegistroClubs)
                .WithRequired(e => e.Clubs)
                .HasForeignKey(e => e.fk_club)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ListaEspera>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<Mensajes>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<Mensajes>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroCitas>()
                .HasMany(e => e.ListaEspera)
                .WithOptional(e => e.RegistroCitas)
                .HasForeignKey(e => e.fk_cita);

            modelBuilder.Entity<RegistroClubs>()
                .HasMany(e => e.ListaEspera)
                .WithOptional(e => e.RegistroClubs)
                .HasForeignKey(e => e.fk_club);

            modelBuilder.Entity<Roles>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Alumnos)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Profesor)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Secretaria)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Secretaria>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Secretaria>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Secretaria>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Secretaria>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Secretaria>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Secretaria>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<TipoClub>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoClub>()
                .HasMany(e => e.Clubs)
                .WithRequired(e => e.TipoClub)
                .HasForeignKey(e => e.fk_tipoClub)
                .WillCascadeOnDelete(false);
        }
    }
}
