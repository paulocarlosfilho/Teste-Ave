using System;

namespace Ave
{
    class Program
    {
        static void Main(string[] args)
        {


            //---------------------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------");

            Ave picaPau = new Ave("Godofredo", "Sim", "Pica Pau da Cabeça Vermelha");

            picaPau.Apresentar();
            picaPau.Voar();
            picaPau.Bicar();
            picaPau.Voar();
            
            Console.WriteLine("----------------------------------------------------");

            //---------------------------------------------------------------------------------------

            Ave penguim = new Ave("Eustácio", "Não", "Pinguim Imperador");

            penguim.Apresentar();
            penguim.Bicar();
            penguim.Voar();

            Console.WriteLine("----------------------------------------------------");
        }
    }
}
