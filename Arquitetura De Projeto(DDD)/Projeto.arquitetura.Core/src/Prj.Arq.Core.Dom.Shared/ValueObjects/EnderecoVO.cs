namespace Projeto.Arquitetura.Core.Domain.Shared.ValueObjects
{
    public class EnderecoVO
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public UFVO UF { get; set; }
        public CepVO CEP { get; set; }
    }
}
