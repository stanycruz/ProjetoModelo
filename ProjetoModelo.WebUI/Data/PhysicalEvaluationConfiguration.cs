using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class PhysicalEvaluationConfiguration : IEntityTypeConfiguration<PhysicalEvaluation>
    {
        public void Configure(EntityTypeBuilder<PhysicalEvaluation> builder)
        {
            builder
                .ToTable("avaliacao_fisica");

            builder
                .Property(a => a.StudentId)
                .HasColumnName("aluno_id");

            builder
                .HasKey(a => a.StudentId);

            builder
                .Property(a => a.Valuer)
                .HasColumnName("avaliador")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.DateTime)
                .HasColumnName("data")
                .HasColumnType("datetime");

            builder
                .Property(a => a.HeartRate)
                .HasColumnName("frequencia_cardiaca");

            builder
                .Property(a => a.Weight)
                .HasColumnName("peso");

            builder
                .Property(a => a.Height)
                .HasColumnName("altura");

            builder
                .Property(a => a.Abdominal)
                .HasColumnName("abdominal");

            builder
                .Property(a => a.FlexionArms)
                .HasColumnName("flexao_bracos");
        }
    }
}