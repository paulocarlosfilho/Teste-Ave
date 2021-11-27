using System;

namespace Ave
{
    class Program
    {
        static void Main(string[] args)
        {
            AveQueVoa picaPau = new AveQueVoa("Pica Pau", "pica-pau-bico-de-marfim");

            picaPau.Apresentar();
            picaPau.Voar();
            picaPau.Bicar();
            
            Console.WriteLine("-----------------------------------");

            //---------------------------------------------------------------------------------------

            AveQueNaoVoa pinguim = new AveQueNaoVoa("Pinguim", "Pinguim-das-Galápagos");

            pinguim.Apresentar();
            pinguim.Voar();
            pinguim.Bicar();

            Console.WriteLine("-----------------------------------");
        }
    }
}
