using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave
{
    class AveQueNaoVoa:IAveQueNaoVoa
    {
        public AveQueNaoVoa(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }

        private string Nome { get; set; }
        private string Especie { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Eu sou um {Nome}!");
        }

        public void Voar()
        {
            Console.WriteLine("Infelizmente,eu não posso voar.");
        }

        public void Bicar()
        {
            Console.WriteLine("Eu estou bicando!");
        }
    }
}
