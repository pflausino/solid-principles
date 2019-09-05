using System;
using System.Collections.Generic;
using System.Text;

namespace Srp.Models
{
    public class Militar
    {
        public string Nome { get; set; }
        public Patente Patente { get; set; }
        public string Acesso { get; set; }
    }

    public enum Patente
    {
        Recruta = 0,
        Soldado = 1,
        Captao = 2,
        Major = 3
    }
}