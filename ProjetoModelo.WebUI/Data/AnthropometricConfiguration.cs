using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class AnthropometricConfiguration : IEntityTypeConfiguration<Anthropometric>
    {
        public void Configure(EntityTypeBuilder<Anthropometric> builder)
        {
            builder
                .ToTable("antopometrica");

            builder
                .Property(a => a.Id)
                .HasColumnName("id");

            builder
                .Property(a => a.Neck)
                .HasColumnName("pescoco");

            builder
                .Property(a => a.Thoracic)
                .HasColumnName("toracica");

            builder
                .Property(a => a.Waist)
                .HasColumnName("cintura");

            builder
                .Property(a => a.Hip)
                .HasColumnName("quadril");

            builder
                .Property(a => a.RelaxedArm)
                .HasColumnName("braco_relaxado");

            builder
                .Property(a => a.ContractedArm)
                .HasColumnName("braco_contraido");

            builder
                .Property(a => a.Forearm)
                .HasColumnName("antebraco");

            builder
                .Property(a => a.UpperThigh)
                .HasColumnName("coxa_superior");

            builder
                .Property(a => a.AverageThigh)
                .HasColumnName("coxa_media");

            builder
                .Property(a => a.LowerThigh)
                .HasColumnName("coxa_inferior");

            builder
                .Property(a => a.Leg)
                .HasColumnName("perna");

            builder
                .Property<long>("avaliacao_fisica_id");

            builder
                .HasOne(a => a.PhysicalEvaluationId)
                .WithMany(pe => pe.Anthropometrics)
                .HasForeignKey("avaliacao_fisica_id");
        }
    }
}