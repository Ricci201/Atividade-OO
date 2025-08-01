using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_OO
{
    public class Carro
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Velocidade { get; set; }

        public int Acelerar(int Acelerar)
        {
            if (Acelerar > 0)
            {
                return Velocidade += Acelerar;
            }

            return Velocidade;
        }

        public int Desacelerar(int Desacelerar)
        {
            if (Desacelerar > 0)
            {
                return Velocidade -= Desacelerar;
            }

            return Velocidade;
        }
    }
}
