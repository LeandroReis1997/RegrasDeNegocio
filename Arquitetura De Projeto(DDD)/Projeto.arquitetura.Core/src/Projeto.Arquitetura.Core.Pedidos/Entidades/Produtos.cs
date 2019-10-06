using Prj.Arq.Core.Dom.Shared.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class Produtos : EntidadeBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Unidade { get; set; }
        public int IdFornecedor { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }
        public virtual ICollection<ItensPedidos> ItensPedidos { get; set; }

        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerUmtamanhoLimite();
            NomeDeveSerPreenchido();
            NomeDeveTerUmtamanhoLimite();
            ValorDeveraserSuperiorAZero();
            UnidadeDeveSerValida();
            ForncedorDeveSerPreenchido();
            return !ListaErros.Any();
        }
        private void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido))
                ListaErros.Add("O campo apelido deve ser preenchido!");
        }
        private void ApelidoDeveTerUmtamanhoLimite()
        {
            if (Apelido.Length > 20)
                ListaErros.Add("O apelido deve ter 20 caracters!");
        }

        private void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome))
                ListaErros.Add("O campo nome deve ser preenchido!");
        }
        private void NomeDeveTerUmtamanhoLimite()
        {
            if (Nome.Length > 150)
                ListaErros.Add("O campo nome deve ter 150 caracters!");
        }
        private void ValorDeveraserSuperiorAZero()
        {
            if (Valor <= 0)
                ListaErros.Add("O campo valor deve ser maior que zero!");
        }
        private void UnidadeDeveSerValida()
        {
            var listUnidade = new List<string> { "KL", "GR", "MT", "CM", "QT" };
            if (!listUnidade.Contains(Unidade)) ListaErros.Add("Unidade deve ser KL, GR, MT, CM ou QT!");
        }
        private void ForncedorDeveSerPreenchido()
        {
            if (IdFornecedor == 0)
                ListaErros.Add("O campo fornecedor deve ser informado!");
        }
    }
}
