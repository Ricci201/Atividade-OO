using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_OO
{
    public class Personagens
    {
        public string? Nome { get; private set; }
        public string? Categoria { get; private set; }
        public int Nivel { get; private set; }
        public int Forca { get; private set; }
        public int Agilidade { get; private set; }
        public int Inteligencia { get; private set; }
        public int Vida { get; private set; }

        public Personagens(string nome, string categoria, int nivel, int forca, int agilidade, int inteligencia, int vida)
        {
            Nome = nome;
            Categoria = categoria;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Categoria: {Categoria}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome}\nNível: {Nivel}\nForça: {Forca}\nAgilidade: {Agilidade}\nInteligência: {Inteligencia}\nVida: {Vida}");
        }
    }
}
