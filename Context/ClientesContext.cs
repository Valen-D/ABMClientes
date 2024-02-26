using ABMClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace ABMClientes.Context;

public partial class ClientesContext : DbContext
{
    public ClientesContext()
    {
    }

    public ClientesContext(DbContextOptions<ClientesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=localhost; Database=Clientes; Trusted_Connection = True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC07AD16B6AB");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuit)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FechaDeNacimiento).HasColumnType("date");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
