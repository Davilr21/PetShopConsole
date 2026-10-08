using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopConsole
{
    public class Passaro : Animal
    {
        public Passaro(string nome, int idade) : base(nome, idade) { }

        public override string FazerSom() => "FiuFiu";
        
    }
}
