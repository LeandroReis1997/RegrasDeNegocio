using Prj.Arq.Core.Dom.Shared.Entidades;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class ItemsPedido: EntidadeBase
    {
        public int Qtd { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }

        public override bool EstaConsistente()
        {
            throw new System.NotImplementedException();
        }
    }
}
