using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace KimberlinSantiago_AP1_P1.Migrations
{
    [DbContext(typeof(DbContextOptions))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("KimberlinSantiago_AP1_P1.Models.Registro", b =>
            {
                b.Property<string>("RegistroId")
                    .HasColumnType("TEXT");

                b.Property<string>("Nombre")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("RegistroId");

                b.ToTable("Registro");
            });
#pragma warning restore 612, 618
        }
    }
}
