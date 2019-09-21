using Prj.Arq.Core.Dom.Shared.Entidades;
using System.Linq;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class Clientes : Pessoa
    {
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
            EnderecoDeverTerUmTamanhoLimite(30);
            BairroDeverTerUmTamanhoLimite(20);
            CidadeDeveSerPreenchida();
            CidadeDeverTerUmTamanhoLimite(20);
            UFDeveSerPreenchido();
            UFDeverSerValido();
            CEPDeverSerValido();

            return !ListaErros.Any();
        }
    }
}
