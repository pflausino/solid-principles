using System;
using System.Collections.Generic;
using System.Text;

namespace Ocp
{
    public class General : Militar, IMilitar
    {
        public void CalculaSalario()
        {
            Salario = 6000;
        }
    }
}