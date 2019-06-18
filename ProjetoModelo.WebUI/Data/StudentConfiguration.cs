using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .ToTable("aluno");

            builder
                .Property(s => s.Id)
                .HasColumnName("id");

            builder
                .Property(s => s.Name)
                .HasColumnName("nome")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.RegistrationDate)
                .HasColumnName("data_cadastro")
                .HasColumnType("datetime");

            builder
                .Property(s => s.Address)
                .HasColumnName("endereco")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.Neighborhood)
                .HasColumnName("bairro")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.ZipCode)
                .HasColumnName("cep")
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder
                .Property(s => s.City)
                .HasColumnName("cidade")
                .HasColumnType("varchar(50)");

            builder
                .Property(s => s.State)
                .HasColumnName("uf")
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder
                .Property(s => s.Phone1)
                .HasColumnName("fone1")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.Phone2)
                .HasColumnName("fone2")
                .HasColumnType("varchar(50)");

            builder
                .Property(s => s.Gender)
                .HasColumnName("genero")
                .HasColumnType("char(1)")
                .IsRequired();

            builder
                .Property(s => s.SocialSecurityNumber)
                .HasColumnName("cpf")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder
                .Property(s => s.Identity)
                .HasColumnName("rg")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder
                .Property(s => s.BornDate)
                .HasColumnName("data_nascimento")
                .HasColumnType("date");

            builder
                .Property(s => s.Age)
                .HasColumnName("idade");

            builder
                .Property(s => s.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.MaritalStatus)
                .HasColumnName("estado_civil")
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Property(s => s.Profession)
                .HasColumnName("profissao")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(s => s.Objective)
                .HasColumnName("objetivo");

            builder
                .Property(s => s.Registered)
                .HasColumnName("matriculado");

            builder
                .Property(s => s.Payment)
                .HasColumnName("pagamento")
                .HasColumnType("money");
        }
    }
}