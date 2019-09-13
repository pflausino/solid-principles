using Newtonsoft.Json.Linq;
using System;

namespace Lsp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //By Epifanio
            Militar captao = new Captao()
            {
                Nome = "Jurupinga Batista",
                TropaLiderada = "Cana Leste"
            };

            Militar sargento = new Sargento()
            {
                Nome = "Corote da Silva",
            };

            Militar gereral = new General()
            {
                Nome = "Jack Daniels Moura"
            };

            //apontando superiores
            captao.ApontaSuperior(gereral);

            sargento.ApontaSuperior(captao);

            //Mostrando Superiores
            JsonToConsole(captao);
            Console.ReadLine();

            JsonToConsole(sargento);
            Console.ReadLine();

            JsonToConsole(gereral);
            Console.ReadLine();
        }

        private static void JsonToConsole(object obj)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            JObject parsed = JObject.Parse(json);

            foreach (var pair in parsed)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            Console.WriteLine("\n");
        }
    }
}