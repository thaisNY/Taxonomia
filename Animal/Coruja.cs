using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomia.Animal
{
    public class Coruja : Animal
    {
        public Coruja()
        {
            Existencia = true;
        }
        public override void Nascer() {
            Console.WriteLine("Eu sou um oviparo ou seja nasço a parti de um ovo, após 33 dias da mae liberar o ovo eu saiu da casca");
        }
        public override void Crescer() {
            Console.WriteLine("Minha mãe cuida de mim até eu aprender a voar o que demora +/- 75 dias depois disso sou independente");
        }
        public override void Reproduzir()
        {
            Console.WriteLine("Quando sou adulto procura uma compainha, acasalamos e a femeas colocam ovos de onde vem os nossos bebes");
        }
        public override void Morrer() {
            Console.WriteLine("Minha vida é curta, vivo por 9 anos mas é bem intessa");
        }
    }
}
