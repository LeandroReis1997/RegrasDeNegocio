using Prj.Arq.Core.Dom.Shared.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class Fornecedores : Pessoa
    {
        public ICollection<Produtos> Produtos { get; set; }
        public override bool EstaConsistente()
        {
            ApelidoDeverSerPreenchido();
            ApelidoDeverTerUmTamanhoLimite(20);
            NomeDeveSerPreenchido();
            NomeDeverTerUmTamanhoLimite(30);
            CPFouCNPJDeveSerPreenchido();
            CPFouCNPJDeveSerValido();
            EmailDeveSerValido();
            EmailDeverTerUmTamanhoLimite(50);
            EnderecoDeveSerPreenchido();
            EnderecoDeverTerUmTamanhoLimite(35);
            BairroDeverTerUmTamanhoLimite(30);
            CidadeDeveSerPreenchida();
            CidadeDeverTerUmTamanhoLimite(30);
            UFDeveSerPreenchido();
            UFDeverSerValido();
            CEPDeverSerValido();

            return !ListaErros.Any();
        }   
    }
}
