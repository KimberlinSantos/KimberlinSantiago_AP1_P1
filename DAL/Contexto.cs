using KimberlinSantiago_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace KimberlinSantiago_AP1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<RegistroPrestamo> Registro { get; set; }
}
