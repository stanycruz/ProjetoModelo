using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.WebUI.Models;

namespace ProjetoModelo.WebUI.Data
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder
                .ToTable("pagamento");

            builder
                .Property(p => p.RegistrationId)
                .HasColumnName("matricula_id");

            builder
                .HasKey(p => p.RegistrationId);

            builder
                .Property(p => p.Value)
                .HasColumnName("valor")
                .HasColumnType("money");

            builder
                .Property(p => p.Payday)
                .HasColumnName("data_pagamento")
                .HasColumnType("datetime");

            builder
                .Property(p => p.FormPayment)
                .HasColumnName("forma_pagamento")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder
                .Property(p => p.PaymentAmount)
                .HasColumnName("valor_pago")
                .HasColumnType("money");

            builder
                .Property(p => p.Historic)
                .HasColumnName("historico");

            builder
                .Property(p => p.Period)
                .HasColumnName("periodo");
        }
    }
}