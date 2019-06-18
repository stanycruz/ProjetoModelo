using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class SkinFoldConfiguration : IEntityTypeConfiguration<SkinFold>
    {
        public void Configure(EntityTypeBuilder<SkinFold> builder)
        {
            builder
                .ToTable("dobra_cutanea");

            builder
                .Property(sf => sf.Id)
                .HasColumnName("id");

            builder
                .Property(sf => sf.Subescapular)
                .HasColumnName("subescapular");

            builder
                .Property(sf => sf.Triceps)
                .HasColumnName("triceps");

            builder
                .Property(sf => sf.Biceps)
                .HasColumnName("biceps");

            builder
                .Property(sf => sf.Breastplate)
                .HasColumnName("peitoral");

            builder
                .Property(sf => sf.AxillaryMeanOblique)
                .HasColumnName("axilar_media_obliqua");

            builder
                .Property(sf => sf.AxillaryMeanVertical)
                .HasColumnName("axilar_media_vertical");

            builder
                .Property(sf => sf.VerticalAbdominal)
                .HasColumnName("abdominal_vertical");

            builder
                .Property(sf => sf.HorizontalAbdominal)
                .HasColumnName("abdominal_horizontal");

            builder
                .Property(sf => sf.SupraIliacOblique)
                .HasColumnName("supra_iliaca_obliqua");

            builder
                .Property(sf => sf.SupraIliacVertical)
                .HasColumnName("supra_iliaca_vertical");

            builder
                .Property(sf => sf.SupraSpinal)
                .HasColumnName("supra_espinhal");

            builder
                .Property(sf => sf.Thigh)
                .HasColumnName("coxa");

            builder
                .HasOne(sf => sf.PhysicalEvaluationId)
                .WithMany(pe => pe.SkinFolds)
                .HasForeignKey("avaliacao_fisica_id");
        }
    }
}