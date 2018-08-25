using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class ModalityConfiguration : IEntityTypeConfiguration<Modality>
    {
        public void Configure(EntityTypeBuilder<Modality> builder)
        {
            builder
                .ToTable("modalidade");

            builder
                .Property(m => m.RegistrationId)
                .HasColumnName("matricula_id");

            builder
                .HasKey(m => m.RegistrationId);

            builder
                .Property(m => m.Description)
                .HasColumnName("descricao")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(m => m.Value)
                .HasColumnName("valor")
                .HasColumnType("money");
        }
    }
}