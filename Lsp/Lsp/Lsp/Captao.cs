using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp
{
    public class Captao : Militar
    {
        public string TropaLiderada { get; set; }

        public void NovaTropa(string nomeTropa)
        {
            TropaLiderada = nomeTropa;
        }
    }
}