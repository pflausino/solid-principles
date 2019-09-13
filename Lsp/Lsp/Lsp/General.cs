using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp
{
    public class General : Militar
    {
        public void RebaixarMilitar()
        {
            Console.WriteLine("Militar Rebaixado");
        }

        public void PromoverMilitar()
        {
            Console.WriteLine("Promover Militar");
        }
    }
}