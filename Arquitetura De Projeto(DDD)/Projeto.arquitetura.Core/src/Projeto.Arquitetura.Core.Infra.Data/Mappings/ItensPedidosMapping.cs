﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Arquitetura.Core.Domain.Pedidos.Entidades;

namespace Projeto.Arquitetura.Core.Infra.Data.Mappings
{
    public class ItensPedidosMapping : IEntityTypeConfiguration<ItensPedidos>
    {
        public void Configure(EntityTypeBuilder<ItensPedidos> builder)
        {
            builder.HasKey(i => i.Id);

            builder.HasOne(i => i.Pedido)
                 .WithMany(p => p.ItensPedidos)
                 .HasForeignKey(i => i.IdPedido);

            builder.HasOne(i => i.Produto)
                .WithMany(p => p.ItensPedidos)
                .HasForeignKey(i => i.IdProduto);

            builder.Ignore(p => p.ListaErros);

            builder.ToTable("ItensPedidos");
        }
    }
}
