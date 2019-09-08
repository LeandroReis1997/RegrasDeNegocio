using System.Collections.Generic;

namespace Prj.Arq.Core.Dom.Shared.Entidades
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public List<string> ListaErros { get; set; }

        public abstract bool EstaConsistente();
    }
}
