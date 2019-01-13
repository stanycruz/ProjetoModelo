using Microsoft.EntityFrameworkCore;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class SolutionContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Modality> Modalities { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<WorkoutSheet> WorkoutSheets { get; set; }
        public DbSet<Frequency> Frequencies { get; set; }
        public DbSet<PhysicalEvaluation> PhysicalEvaluations { get; set; }
        public DbSet<Anthropometric> Anthropometrics { get; set; }
        public DbSet<SkinFold> SkinFolds { get; set; }
        public DbSet<Diameter> Diameters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-HFNV728;Initial Catalog=ProjetoModelo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new RegistrationConfiguration());
            modelBuilder.ApplyConfiguration(new ModalityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new WorkoutSheetConfiguration());
            modelBuilder.ApplyConfiguration(new FrequencyConfiguration());
            modelBuilder.ApplyConfiguration(new PhysicalEvaluationConfiguration());
            modelBuilder.ApplyConfiguration(new AnthropometricConfiguration());
            modelBuilder.ApplyConfiguration(new SkinFoldConfiguration());
            modelBuilder.ApplyConfiguration(new DiameterConfiguration());
        }
    }
}
