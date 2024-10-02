using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escrevendo_as_Classes_de_Um_Jogo.models
{
    public class Heroi
    {
        public Heroi(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }
        
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public void Atacar()
        {
            string ataque = "";

            if (Tipo == "Mago")
            {
                ataque = "magia";
            }
            else if (Tipo == "Guerreiro")
            {
                ataque = "espada";
            }
            else if (Tipo == "Monge")
            {
                ataque = "artes marciais";
            }
            else
            {
                ataque = "shuriken";
            }

            Console.WriteLine();
            Console.WriteLine($"O {Nome} atacou usando -{ataque}-");
            Console.WriteLine();
        }
    }
}