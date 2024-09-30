using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KimberlinSantiago_AP1_P1.Models
{
    
    
        public class Prestamo
        {
            public int Id { get; set; } 
            public string Deudor { get; set; }
            public string Concepto { get; set; }
            public decimal Monto { get; set; }
        }






}
