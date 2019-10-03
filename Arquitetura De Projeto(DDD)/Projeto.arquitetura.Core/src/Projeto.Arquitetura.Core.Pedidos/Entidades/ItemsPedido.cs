using Prj.Arq.Core.Dom.Shared.Entidades;
using System.Linq;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class ItemsPedido: EntidadeBase
    {
        public int Qtd { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }

        public override bool EstaConsistente()
        {
            QtdDeveSerSuperiorAZero();
            ItemDePedidoDeveSerAssociadoAUmPedido();
            ProdutoDeveSerPreenchido();

            return !ListaErros.Any();
        }

        private void QtdDeveSerSuperiorAZero()
        {
            if (Qtd <= 0) ListaErros.Add("Qtd. deverá ser informada!");
        }
        private void ItemDePedidoDeveSerAssociadoAUmPedido()
        {
            if (IdPedido <= 0) ListaErros.Add("Nº. pedido inválido!");
        }

        private void ProdutoDeveSerPreenchido()
        {
            if (IdProduto <= 0) ListaErros.Add("Produto deve ser informado!");
        }
    }
}
