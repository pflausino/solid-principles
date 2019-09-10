using System;
using System.Collections.Generic;
using System.Text;

namespace Ocp
{
    public class CalcularSalario
    {
        public double Calcula(Militar militar)
        {
            double salario;
            switch (militar.Patente)
            {
                case Patente.Soldado:
                    salario = 1000;
                    break;

                case Patente.Captao:
                    salario = 2000;
                    break;

                case Patente.Major:
                    salario = 1000;
                    break;

                default:
                    salario = 0;
                    break;
            }
            return salario;
        }
    }
}