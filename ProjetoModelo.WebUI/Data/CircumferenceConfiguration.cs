using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class CircumferenceConfiguration : IEntityTypeConfiguration<Circumference>
    {
        public void Configure(EntityTypeBuilder<Circumference> builder)
        {
            builder
                .ToTable("circunferencia");

            builder
                .Property(c => c.Id)
                .HasColumnName("id");

            builder
                .Property(c => c.Gluteal)
                .HasColumnName("glutea");

            builder
                .Property(c => c.Calf)
                .HasColumnName("panturrilha");

            builder
                .Property(c => c.Maleoar)
                .HasColumnName("maleoar");

            builder
                .Property(c => c.IMTrunk)
                .HasColumnName("troncoIM");

            builder
                .Property(c => c.EMTrunk)
                .HasColumnName("troncoEM");

            builder
                .HasOne(c => c.PhysicalEvaluationId)
                .WithMany(pe => pe.Circumferences)
                .HasForeignKey("avaliacao_fisica_id");
        }
    }
}