using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KimberlinSantiago_AP1_P1.Models
{


    using System.ComponentModel.DataAnnotations;

    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Deudor { get; set; }

        [Required]
        [StringLength(200)]
        public required string Concepto { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a 0.")]
        public decimal Monto { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }


}