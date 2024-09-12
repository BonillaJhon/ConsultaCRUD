using ConsultaCRUD.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Persona> Personas { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>()
            .HasOne(p => p.Usuarios)
            .WithOne(u => u.Persona)
            .HasForeignKey<Usuarios>(u => u.PersonaId)
            .IsRequired(false);  // Relación opcional
    }



}
