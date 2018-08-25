using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class FrequencyConfiguration : IEntityTypeConfiguration<Frequency>
    {
        public void Configure(EntityTypeBuilder<Frequency> builder)
        {
            builder
                .ToTable("frequencia");

            builder
                .Property(f => f.StudentId)
                .HasColumnName("aluno_id");

            builder
                .HasKey(f => f.StudentId);

            builder
                .Property(f => f.DateEntry)
                .HasColumnName("data_entrada")
                .HasColumnType("datetime");

            builder
                .Property(f => f.DepartureDate)
                .HasColumnName("data_saida")
                .HasColumnType("datetime");
        }
    }
}