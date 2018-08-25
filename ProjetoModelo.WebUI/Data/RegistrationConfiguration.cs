using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder
                .ToTable("matricula");

            builder
                .Property(r => r.StudentId)
                .HasColumnName("aluno_id");

            builder
                .HasKey(r => r.StudentId);

            builder
                .Property(r => r.EffectiveDate)
                .HasColumnName("data_vigencia")
                .HasColumnType("datetime");

            builder
                .Property(r => r.Plan)
                .HasColumnName("plano");

            builder
                .Property(r => r.DueDate)
                .HasColumnName("data_vencimento")
                .HasColumnType("datetime");

            builder
                .Property(r => r.Discount)
                .HasColumnName("desconto");

            builder
                .Property(r => r.Situation)
                .HasColumnName("situacao")
                .HasColumnType("varchar(20)");

            builder
                .Property(r => r.EndDate)
                .HasColumnName("data_fim")
                .HasColumnType("datetime");
        }
    }
}