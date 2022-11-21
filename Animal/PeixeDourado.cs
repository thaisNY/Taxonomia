using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomia.Animal
{
    public class PeixeDourado : Animal
    {
        public PeixeDourado()
        {
            Existencia = true;
        }
        public override void Nascer()
        {
            Console.WriteLine("Eu sou um oviparo ou seja nasço a parti de um ovo parecido com as aves mas não preciso ser encubado");
        }
        public override void Crescer()
        {
            Console.WriteLine("De 4 a 10 meses atinjo meu peso maximo");
        }
        public override void Reproduzir()
        {
            Console.WriteLine("Me reproduzo de forma sexuada e as femeas geram ovos");
        }
        public override void Morrer()
        {
            Console.WriteLine("Posso viver de 2 a 5 anos");
        }
    }
}
