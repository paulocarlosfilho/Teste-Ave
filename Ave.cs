using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esté foi o método que eu pensei antes. Nesse pronto eu travei. Pensei... "Desse jeito nao tenho como fazer uma Ave que não voa...
//Preciso criar duas classes, uma voa e a outra nao."

namespace Ave
{
    class Ave
    {
        public Ave(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
