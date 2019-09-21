using Projeto.Arquitetura.Core.Domain.Shared.ValueObjects;

namespace Prj.Arq.Core.Dom.Shared.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public Pessoa()
        {
            CPFCNPJ = new CpfCnpjVO();
            Email = new EmailVO();
            Endereco = new EnderecoVO();
        }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public CpfCnpjVO CPFCNPJ { get; set; }
        public EmailVO Email { get; set; }
        public EnderecoVO Endereco { get; set; }

        protected void ApelidoDeverSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListaErros.Add("Apelido deve ser preenchido!");
        }

        protected void ApelidoDeverTerUmTamanhoLimite(int tamanho)
        {
            if (Apelido.Trim().Length > tamanho) ListaErros.Add($"O campo apelido deve ter no máximo {tamanho} caracters!");
        }

        protected void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) ListaErros.Add("Nome deve ser preenchido!");
        }

        protected void NomeDeverTerUmTamanhoLimite(int tamanho)
        {
            if (Nome.Trim().Length > tamanho) ListaErros.Add($"O campo nome deve ter no máximo {tamanho} caracters!");
        }

        protected void CPFouCNPJDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(CPFCNPJ.Numero)) ListaErros.Add("CPF ou CNPJ deve ser preenchido!");
        }

        protected void CPFouCNPJDeveSerValido()
        {
            if (!CPFCNPJ.Validar(CPFCNPJ.Numero)) ListaErros.Add("Digite um CPF ou CNPJ válido!");
        }

        protected void EmailDeveSerValido()
        {
            if (!Email.Validar(Email.Endereco)) ListaErros.Add("Digite um email válido");
        }

        protected void EmailDeverTerUmTamanhoLimite(int tamanho)
        {
            if (Email.Endereco.Trim().Length > tamanho) ListaErros.Add($"O campo email deve ter no máximo {tamanho} caracters!");
        }

        protected void EnderecoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Logradouro)) ListaErros.Add("Logradouro deve ser preenchido!");
        }

        protected void EnderecoDeverTerUmTamanhoLimite(int tamanho)
        {
            if (Endereco.Logradouro.Trim().Length > tamanho) ListaErros.Add($"O campo logradouro deve ter no máximo {tamanho} caracters!");
        }

        protected void BairroDeverTerUmTamanhoLimite(int tamanho)
        {
            if (Endereco.Bairro.Trim().Length > tamanho) ListaErros.Add($"O campo bairro deve ter no máximo {tamanho} caracters!");
        }

        protected void CidadeDeveSerPreenchida()
        {
            if (string.IsNullOrEmpty(Endereco.Cidade)) ListaErros.Add("Cidade deve ser preenchido!");
        }

        protected void CidadeDeverTerUmTamanhoLimite(int tamanho)
        {
            if (Endereco.Cidade.Trim().Length > tamanho) ListaErros.Add($"O campo cidade deve ter no máximo {tamanho} caracters!");
        }

        protected void UFDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.UF.UF)) ListaErros.Add("UF deve ser preenchido!");
        }

        protected void UFDeverSerValido()
        {
            if (!Endereco.UF.Validar(Endereco.UF.UF)) ListaErros.Add("Digite uma UF válida!");
        }

        protected void CEPDeverSerValido()
        {
            if (!Endereco.CEP.Validar(Endereco.CEP.Codigo)) ListaErros.Add("Digite um CEP válido");
        }
    }
}
