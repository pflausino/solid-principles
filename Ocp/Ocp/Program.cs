using System;

namespace Ocp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var capMichael = new Militar
            {
                Nome = "Michael",
                Patente = Patente.Recruta
            };

            CalcularSalario calcularSalario = new CalcularSalario();

            var salario = calcularSalario.Calcula(capMichael);

            Console.WriteLine($"O Salario do { capMichael.Nome } é de {salario}");

            Console.ReadLine();
        }
    }
}