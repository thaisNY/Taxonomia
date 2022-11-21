using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomia.Animal
{
    public class Dragao : Animal
    {
        public Dragao()
        {
            Existencia = false;
        }
        public override void Nascer()
        {
            Console.WriteLine("Não existo então não posso nascer");
        }
        public override void Crescer()
        {
            Console.WriteLine("Não existo então não posso crescer");
        }
        public override void Reproduzir()
        {
            Console.WriteLine("Não existo então não posso reproduzir");
        }
        public override void Morrer()
        {
            Console.WriteLine("Não existo então não posso morrer. Isso faz de mim eterno?");
        }
    }
}
