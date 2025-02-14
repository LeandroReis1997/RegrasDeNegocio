﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Arquitetura.Core.Domain.Pedidos.Entidades;

namespace Projeto.Arquitetura.Core.Infra.Data.Mappings
{
    public class FornecedoresMapping : IEntityTypeConfiguration<Fornecedores>
    {
        public void Configure(EntityTypeBuilder<Fornecedores> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Apelido)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.HasIndex(f => f.Apelido).IsUnique();

            builder.Property(f => f.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.OwnsOne(f => f.CPFCNPJ, cpfcnpj =>
            {
                cpfcnpj.Property(c => c.Numero)
                    .IsRequired()
                    .HasColumnName("CpfCnpj")
                    .HasColumnType("varchar(14)");

                cpfcnpj.HasIndex(c => c.Numero).IsUnique();

            });

            builder.OwnsOne(f => f.Email, email =>
            {
                email.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasColumnType("varchar(100)");

            });

            builder.OwnsOne(f => f.Endereco, ender =>
            {
                ender.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasColumnName("Endereco")
                    .HasColumnType("varchar(100)");

                ender.Property(e => e.Bairro)
                   .HasColumnName("Bairro")
                   .HasColumnType("varchar(30)");

                ender.Property(e => e.Cidade)
                   .HasColumnName("Cidade")
                   .IsRequired()
                   .HasColumnType("varchar(30)");
            });

            builder.OwnsOne(f => f.Endereco).OwnsOne(u => u.UF, uf =>
            {
                uf.Property(e => e.UF)
                    .HasColumnName("UF")
                    .HasColumnType("varchar(2)");
            });


            builder.OwnsOne(f => f.Endereco).OwnsOne(c => c.CEP, cep =>
            {
                cep.Property(e => e.Codigo)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(8)");

                cep.Ignore(c => c.Endereco);
                cep.Ignore(c => c.Bairro);
                cep.Ignore(c => c.Cidade);
                cep.Ignore(c => c.UF);

            });

            builder.Ignore(f => f.ListaErros);

            builder.ToTable("Fornecedres");
        }
    }
}
