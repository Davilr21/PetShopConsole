using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopConsole
{
    public class Cachorro : Animal
    {
        public Cachorro(String nome, int idade) : base(nome, idade) { }

        public override string FazerSom() => "Au Au";
    }
}
