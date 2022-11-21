using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomia.Animal
{
    public class Cachorro : Animal
    {
        public Cachorro()
        {
            Existencia = true;
        }
        public override void Nascer()
        {
            Console.WriteLine("Eu sou um mamifero ou seja nasço a parti do ultero da minha mae e bebo seu leite materno");
        }
        public override void Crescer()
        {
            Console.WriteLine("Me torno adulto com 2 anos mas posso ser desmamado com 45 dias");
        }
        public override void Reproduzir()
        {
            Console.WriteLine("Reproduzo de forma sexuada e a gestação dos meus filhotes leva mais ou menos 70 dias");
        }
        public override void Morrer()
        {
            Console.WriteLine("Vivo entre 12 a 15 anos");
        }
    }
}
