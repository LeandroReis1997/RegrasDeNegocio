using Prj.Arq.Core.Dom.Shared.Entidades;
using System.Linq;

namespace Projeto.Arquitetura.Core.Domain.Pedidos.Entidades
{
    public class Clientes : Pessoa
    {
        public override bool EstaConsistente()
        {
            ApelidoDeverSerPreenchido();
            ApelidoDeverTerUmTamanhoLimite();
            NomeDeveSerPreenchido();
            NomeDeverTerUmTamanhoLimite();
            CPFouCNPJDeveSerPreenchido();
            CPFouCNPJDeveSerValido();
            EmailDeveSerValido();
            EmailDeverTerUmTamanhoLimite();
            EnderecoDeveSerPreenchido();
            EnderecoDeverTerUmTamanhoLimite();
            BairroDeverTerUmTamanhoLimite();
            CidadeDeveSerPreenchida();
            CidadeDeverTerUmTamanhoLimite();
            UFDeveSerPreenchido();
            UFDeverTerSerValido();
            CEPDeverTerSerValido();

            return !ListaErros.Any();
        }

        private void ApelidoDeverSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListaErros.Add("Apelido deve ser preenchido!");
        }

        private void ApelidoDeverTerUmTamanhoLimite()
        {
            if (Apelido.Trim().Length >= 20) ListaErros.Add("O campo apelido deve ter no máximo 20 caracters!");
        }

        private void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) ListaErros.Add("Nome deve ser preenchido!");
        }

        private void NomeDeverTerUmTamanhoLimite()
        {
            if (Nome.Trim().Length > 50) ListaErros.Add("O campo nome deve ter no máximo 50 caracters!");
        }

        private void CPFouCNPJDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(CPFCNPJ.Numero)) ListaErros.Add("CPF ou CNPJ deve ser preenchido!");
        }

        private void CPFouCNPJDeveSerValido()
        {
            if (!CPFCNPJ.Validar(CPFCNPJ.Numero)) ListaErros.Add("Digite um CPF ou CNPJ válido!");
        }

        private void EmailDeveSerValido()
        {
            if (!Email.Validar(Email.Endereco)) ListaErros.Add("Digite um email válido");
        }

        private void EmailDeverTerUmTamanhoLimite()
        {
            if (Email.Endereco.Trim().Length > 30) ListaErros.Add("O campo email deve ter no máximo 30 caracters!");
        }

        private void EnderecoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Logradouro)) ListaErros.Add("Logradouro deve ser preenchido!");
        }

        private void EnderecoDeverTerUmTamanhoLimite()
        {
            if (Endereco.Logradouro.Trim().Length > 30) ListaErros.Add("O campo logradouro deve ter no máximo 30 caracters!");
        }

        private void BairroDeverTerUmTamanhoLimite()
        {
            if (Endereco.Bairro.Trim().Length > 30) ListaErros.Add("O campo bairro deve ter no máximo 30 caracters!");
        }

        private void CidadeDeveSerPreenchida()
        {
            if (string.IsNullOrEmpty(Endereco.Cidade)) ListaErros.Add("Cidade deve ser preenchido!");
        }

        private void CidadeDeverTerUmTamanhoLimite()
        {
            if (Endereco.Cidade.Trim().Length > 25) ListaErros.Add("O campo cidade deve ter no máximo 25 caracters!");
        }

        private void UFDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.UF.UF)) ListaErros.Add("UF deve ser preenchido!");
        }

        private void UFDeverTerSerValido()
        {
            if (!Endereco.UF.Validar(Endereco.UF.UF)) ListaErros.Add("Digite uma UF válida!");
        }
        
        private void CEPDeverTerSerValido()
        {
            if (!Endereco.CEP.Validar(Endereco.CEP.Codigo)) ListaErros.Add("Digite um CEP válido");
        }


    }
}
