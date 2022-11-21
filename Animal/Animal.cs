using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomia.Animal
{
    public abstract class Animal
    {   
        //Atributos
        public string Filo { get; set; }
        public string Especie { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }

        public bool Existencia { get; set; }

        //Construtor não abstrato
        public Animal() 
        {
            Existencia = true;
        }
        
        //Metodos abstratos
        public abstract void Nascer();
        public abstract void Crescer();
        public abstract void Reproduzir();
        public abstract void Morrer();
    }
}
