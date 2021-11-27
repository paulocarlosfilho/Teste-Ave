using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esté foi o método que eu pensei antes. Nesse pronto eu travei. Pensei... "Desse jeito nao tenho como fazer uma Ave que não voa...
//Preciso criar duas classes, uma voa e a outra nao."

//-----------------------------------------------------------------------------

//Técnicamente, eu corrigi o bug... deixei os outros arquivos ai, mas eu so precisei desse aqui e da IAve.
//As outras classes e interfaces imagino que eu possa deletar depois;

namespace Ave
{
    class Ave:IAve
    {
        
        public Ave(string nome, string voa, string especie)
        {
            Nome = nome;
            Voa = voa;
            Especie = especie;
        }

        public string Nome { get; set; }
        private string Voa { get; set; }
        private string Especie { get; set; }

        //-----------------------------------------------------------------------------
        public void Voar()
        {
            if(Voa == "Sim")
            {
                Console.WriteLine("Eu estou voando!");
            }
            else if (Voa == "Não")
            {
                Console.WriteLine("Infelizmente, eu não posso voar.");
            }
            else
                Console.WriteLine("Erro! Por favor insira a penas Sim ou Não.");
        }

        //-----------------------------------------------------------------------------
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Eu sou o {Nome} e minha espécie é {Especie}.");
        }

        //-----------------------------------------------------------------------------

        public void Bicar()
        {
            Console.WriteLine("Agora eu estou a bicar!");
        }
    }
}
