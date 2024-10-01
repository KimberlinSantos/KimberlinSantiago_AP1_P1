using KimberlinSantiago_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using RegistroPrestamosApp.Data;

namespace RegistroPrestamosApp.DAL
{
    public interface IPrestamoRepository
    {
        Task<List<Prestamo>> ObtenerPrestamos();
        Task AgregarPrestamo(Prestamo prestamo);
    }
}


namespace RegistroPrestamosApp.DAL
{
    public class PrestamoRepository : IPrestamoRepository
    {
        private readonly ApplicationDbContext _context;

        public PrestamoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Prestamo>> ObtenerPrestamos()
        {
            return await _context.Prestamos.ToListAsync();
        }

        public async Task AgregarPrestamo(Prestamo prestamo)
        {
            await _context.Prestamos.AddAsync(prestamo);
            await _context.SaveChangesAsync();
        }
    }
}

