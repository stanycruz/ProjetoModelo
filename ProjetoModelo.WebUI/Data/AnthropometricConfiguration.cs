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


        }
    }
}