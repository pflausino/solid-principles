using Srp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Srp
{
    public class MilitarBase
    {
        private readonly string _enderecoDeLog = Path.Combine(Directory.GetCurrentDirectory(), "logDbFile.txt");

        public void Acessar()
        {
            var militar = new Militar("Michael", Patente.Major, "Gabinete");

            if (militar.Acesso == "Entrada")
            {
                string message = "Acesso Permitido";
                saveLog(militar, message);
                AvisoConsole(militar, message);
                return;
            }
            if (militar.Acesso == "Gabinete" && militar.Patente >= Patente.Captao)
            {
                string message = "Acesso Permitido";
                saveLog(militar, message);
                AvisoConsole(militar, message);
            }
            else
            {
                string message = "Acesso Negado";

                saveLog(militar, message);
                AvisoConsole(militar, message);
            }
        }

        private string MontaLog(Militar militar, string resultadoAcesso)
        {
            var oldLog = File.ReadAllText(_enderecoDeLog, Encoding.UTF8);
            return oldLog +
                $"Acesso de : {militar.Nome} as {DateTime.Now}" +
                Environment.NewLine +
                resultadoAcesso +
                Environment.NewLine;
        }

        private void saveLog(Militar militar, string resultadoAcesso)
        {
            File.WriteAllText(_enderecoDeLog, MontaLog(militar, resultadoAcesso));
        }

        private void AvisoConsole(Militar militar, string resultadoAcesso)
        {
            if (resultadoAcesso == "Acesso Negado")
                Console.WriteLine($"{militar.Nome} Nao pode entrar");
            else
                Console.WriteLine($"Bem vindo Sr {militar.Nome}");
        }
    }
}