using KimberlinSantiago_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace RegistroPrestamosApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Prestamo> Prestamos { get; set; }
    }
}
