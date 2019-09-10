using Srp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Srp
{
    public class MilitarBase
    {
        public void Acessar()
        {
            //1 - Criar um Militar
            var militar = new Militar();

            militar.Nome = "Michael";
            militar.Patente = Patente.Recruta;
            militar.Acesso = "Gabinente";

            //2 - Formatando Log
            string enderecoDeLog = Path.Combine(Directory.GetCurrentDirectory(), "logDbFile.txt");
            var oldLog = File.ReadAllText(enderecoDeLog, Encoding.UTF8);
            var newLog = oldLog + $"Acesso de : {militar.Nome} as {DateTime.Now}" + Environment.NewLine;

            if (militar.Acesso == "Entrada")
            {
                //3 - Adiciona ao log
                newLog += "Acesso Permitido" + Environment.NewLine;
                //4 - Exibe o resultado de acesso
                Console.WriteLine($"Bem vindo Sr {militar.Nome}");
            }

            if (militar.Acesso == "Gabinente" && militar.Patente >= Patente.Captao)
            {
                newLog += "Acesso Permitido" + Environment.NewLine;
                Console.WriteLine($"Bem vindo Sr {militar.Nome}");
            }
            else
            {
                newLog += "Acesso Negado" + Environment.NewLine;
                Console.WriteLine($"Nao pode entrar");
            }
            //5 - Grava Log
            File.WriteAllText(enderecoDeLog, newLog);
        }
    }
}