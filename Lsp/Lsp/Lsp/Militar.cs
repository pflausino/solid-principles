using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp
{
    public class Militar
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Militar SuperiorImediato { get; set; } = null;

        public virtual void ApontaSuperior(Militar militar)
        {
            SuperiorImediato = militar;
        }
    }
}