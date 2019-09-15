﻿using Projeto.Arquitetura.Core.Domain.Shared.ValueObjects;

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
    }
}
