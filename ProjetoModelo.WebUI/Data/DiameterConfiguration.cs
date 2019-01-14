using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class DiameterConfiguration : IEntityTypeConfiguration<Diameter>
    {
        public void Configure(EntityTypeBuilder<Diameter> builder)
        {
            builder
                .ToTable("diametro");

            builder
                .Property(d => d.Id)
                .HasColumnName("id");

            builder
                .Property(d => d.RadioUlnar)
                .HasColumnName("radio_ulnar");

            builder
                .Property(d => d.Umeral)
                .HasColumnName("umeral");

            builder
                .Property(d => d.Biacromial)
                .HasColumnName("biacromial");

            builder
                .Property(d => d.TransverseThoracic)
                .HasColumnName("toracico_transversal");

            builder
                .Property(d => d.AnteriorThoracic)
                .HasColumnName("toracico_anterior");

            builder
                .Property(d => d.PosteriorThoracic)
                .HasColumnName("toracico_posterior");

            builder
                .Property(d => d.Bicristal)
                .HasColumnName("bicristal");

            builder
                .Property(d => d.Bitrocanterian)
                .HasColumnName("bitrocanteriano");

            builder
                .Property(d => d.Femular)
                .HasColumnName("femular");

            builder
                .Property(d => d.Maleolar)
                .HasColumnName("maleolar");

            builder
                .HasOne(d => d.PhysicalEvaluationId)
                .WithMany(pe => pe.Diameters)
                .HasForeignKey("avaliacao_fisica_id");
        }
    }
}