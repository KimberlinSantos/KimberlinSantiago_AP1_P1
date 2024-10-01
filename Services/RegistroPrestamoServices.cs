using KimberlinSantiago_AP1_P1.Models;

namespace RegistroPrestamos.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();

        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamo.Id = prestamos.Count + 1; 
            prestamos.Add(prestamo);
        }

        public List<Prestamo> ObtenerPrestamos()
        {
            return prestamos;
        }
    }
}
