using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_OO
{
    public class Gato() : Animal("Gato")
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O gato faz: Miau!");
        }
    }
}
