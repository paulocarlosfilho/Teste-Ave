using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave
{
    class AveQueVoa:IAveQueVoa
    {
        public AveQueVoa(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }

        private string Nome { get; set; }
        private string Especie { get; set; }

        public void Voar()
        {
            Console.WriteLine("Estou voando!");
        }

        public void Bicar()
        {
            Console.WriteLine("Estou bicando.");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Eu sou um {Nome}.");
        }
    }
}
