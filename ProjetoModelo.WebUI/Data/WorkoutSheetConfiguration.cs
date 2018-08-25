using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class WorkoutSheetConfiguration : IEntityTypeConfiguration<WorkoutSheet>
    {
        public void Configure(EntityTypeBuilder<WorkoutSheet> builder)
        {
            builder
                .ToTable("ficha_treino");

            builder
                .Property(w => w.StudentId)
                .HasColumnName("aluno_id");

            builder
                .HasKey(w => w.StudentId);

            builder
                .Property(w => w.DateTime)
                .HasColumnName("data")
                .HasColumnType("datetime");

            builder
                .Property(w => w.Coach)
                .HasColumnName("professor")
                .HasColumnType("varchar(50)");

            builder
                .Property(w => w.WorkoutA)
                .HasColumnName("treino_a");

            builder
                .Property(w => w.DayA)
                .HasColumnName("dia_a")
                .HasColumnType("datetime");

            builder
                .Property(w => w.WorkoutB)
                .HasColumnName("treino_b");

            builder
                .Property(w => w.DayB)
                .HasColumnName("dia_b")
                .HasColumnType("datetime");

            builder
                .Property(w => w.WorkoutC)
                .HasColumnName("treino_c");

            builder
                .Property(w => w.DayC)
                .HasColumnName("dia_c")
                .HasColumnType("datetime");

            builder
                .Property(w => w.WorkoutD)
                .HasColumnName("treino_d");

            builder
                .Property(w => w.DayD)
                .HasColumnName("dia_d")
                .HasColumnType("datetime");

            builder
                .Property(w => w.WorkoutE)
                .HasColumnName("treino_e");

            builder
                .Property(w => w.DayE)
                .HasColumnName("dia_e")
                .HasColumnType("datetime");

            builder
                .Property(w => w.WorkoutF)
                .HasColumnName("treino_f");

            builder
                .Property(w => w.DayF)
                .HasColumnName("dia_f")
                .HasColumnType("datetime");
        }
    }
}