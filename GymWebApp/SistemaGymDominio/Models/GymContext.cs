namespace SistemaGymDominio.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GymContext : DbContext
    {
        public GymContext()
            : base("name=GymContext")
        {
        }

        public virtual DbSet<TBBOLETA> TBBOLETAs { get; set; }
        public virtual DbSet<TBCLASE> TBCLASEs { get; set; }
        public virtual DbSet<TBCLIENTE> TBCLIENTEs { get; set; }
        public virtual DbSet<TBDETBOLETA> TBDETBOLETAs { get; set; }
        public virtual DbSet<TBEMPRESA> TBEMPRESAs { get; set; }
        public virtual DbSet<TBENTRENADOR> TBENTRENADORs { get; set; }
        public virtual DbSet<TBPLAN> TBPLANs { get; set; }
        public virtual DbSet<TBUSUARIO> TBUSUARIOs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.CodigoEmp)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.NombreEmp)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.DniCli)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.NombreCli)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.Total)
                .HasPrecision(6, 2);

            modelBuilder.Entity<TBBOLETA>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<TBBOLETA>()
                .HasMany(e => e.TBDETBOLETAs)
                .WithRequired(e => e.TBBOLETA)
                .HasForeignKey(e => new { e.Serie, e.Numero })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBCLASE>()
                .Property(e => e.NombreClase)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLASE>()
                .Property(e => e.Entrenador)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLASE>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLASE>()
                .Property(e => e.Dia)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLASE>()
                .Property(e => e.Horario)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .Property(e => e.NomPlan)
                .IsUnicode(false);

            modelBuilder.Entity<TBCLIENTE>()
                .HasMany(e => e.TBBOLETAs)
                .WithOptional(e => e.TBCLIENTE)
                .HasForeignKey(e => e.DniCli);

            modelBuilder.Entity<TBDETBOLETA>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<TBDETBOLETA>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TBDETBOLETA>()
                .Property(e => e.CodigoPlan)
                .IsUnicode(false);

            modelBuilder.Entity<TBDETBOLETA>()
                .Property(e => e.NombrePlan)
                .IsUnicode(false);

            modelBuilder.Entity<TBDETBOLETA>()
                .Property(e => e.Precio)
                .HasPrecision(6, 2);

            modelBuilder.Entity<TBDETBOLETA>()
                .Property(e => e.Importe)
                .HasPrecision(6, 2);

            modelBuilder.Entity<TBEMPRESA>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TBEMPRESA>()
                .Property(e => e.Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<TBEMPRESA>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBEMPRESA>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TBEMPRESA>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TBEMPRESA>()
                .HasMany(e => e.TBBOLETAs)
                .WithOptional(e => e.TBEMPRESA)
                .HasForeignKey(e => e.Sucursal);

            modelBuilder.Entity<TBEMPRESA>()
                .HasMany(e => e.TBENTRENADORs)
                .WithOptional(e => e.TBEMPRESA)
                .HasForeignKey(e => e.CodSucursal);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.CodSucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TBENTRENADOR>()
                .HasMany(e => e.TBCLASEs)
                .WithOptional(e => e.TBENTRENADOR)
                .HasForeignKey(e => e.Entrenador);

            modelBuilder.Entity<TBPLAN>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TBPLAN>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBPLAN>()
                .Property(e => e.Costo)
                .HasPrecision(6, 2);

            modelBuilder.Entity<TBPLAN>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TBPLAN>()
                .HasMany(e => e.TBDETBOLETAs)
                .WithOptional(e => e.TBPLAN)
                .HasForeignKey(e => e.CodigoPlan);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Dni)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Turno)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.CodigoSucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TBUSUARIO>()
                .Property(e => e.Estado)
                .IsUnicode(false);
        }
    }
}
