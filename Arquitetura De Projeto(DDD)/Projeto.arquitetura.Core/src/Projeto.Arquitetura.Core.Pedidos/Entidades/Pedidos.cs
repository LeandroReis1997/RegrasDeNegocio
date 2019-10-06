using Prj.Arq.Core.Dom.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class Pedidos : EntidadeBase
    {
        public DateTime DataPedido { get; set; }
        public DateTime? DataEntrega { get; set; }
        public int IdCliente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual ICollection<ItensPedidos> ItensPedidos { get; set; }


        public override bool EstaConsistente()
        {
            DataPedidoDeveSerPreenchido();
            DataPedidoDeveSerSuperiorOuIgualADataDoDia();
            DataEntregaDeveSerSuperiorOuIgualADataDoDia();
            ClienteDeveSerPreenchido();
            return !ListaErros.Any();
        }

        private void DataPedidoDeveSerPreenchido()
        {
            if (DataPedido == null) ListaErros.Add("Preencha a data do pedido.");
        }

        private void DataPedidoDeveSerSuperiorOuIgualADataDoDia()
        {
            if (DataPedido < DateTime.Today) ListaErros.Add("Data do pedido não pode ser superior a data de hoje.");
        }

        private void DataEntregaDeveSerSuperiorOuIgualADataDoDia()
        {
            if (DataEntrega != null && DataEntrega < DataPedido) ListaErros.Add("Data da entrega deve ser superior a data do pedido");
        }

        private void ClienteDeveSerPreenchido()
        {
            if (IdCliente == 0)
                ListaErros.Add("O cliente deve ser informado!");
        }
    }
}
