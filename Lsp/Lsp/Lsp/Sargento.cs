using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp
{
    public class Sargento : Militar
    {
        public List<string> EspecialidadesDeCampo { get; set; }

        public void AdicionaEspecialidade(string especialidade)
        {
            EspecialidadesDeCampo.Add(especialidade);
        }
    }
}