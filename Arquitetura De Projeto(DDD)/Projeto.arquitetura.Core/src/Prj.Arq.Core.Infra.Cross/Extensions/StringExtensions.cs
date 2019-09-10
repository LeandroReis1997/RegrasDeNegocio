using System;
using System.Linq;

namespace Projeto.Arquitetura.Core.Infra.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string SomenteNumeros(this string strIn)
        {
            if(strIn != null)
            {
                var somentenumeros = new String(strIn.Where(x => Char.IsDigit(x)).ToArray());
                return somentenumeros;
            }
            return "";
        }

        public static string SomenteLetras(this string strIn)
        {
            if (strIn != null)
            {
                var somenteletras = new String(strIn.Where(x => Char.IsLetter(x)).ToArray());
                return somenteletras;
            }
            return "";
        }

    }
}
