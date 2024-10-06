using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escrevendo_as_Classes_de_Um_Jogo.models
{
    public class Heroi
    {
        // Construtores para as propriedades Nome e Tipo.
        public Heroi(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        // Propriedades da classe Heroi.
        string _nome;
        public string Nome 
        {
            get => _nome;
            
            set
            {
                // Validação para o nome não ser vazio. Caso o nome seja vazio uma exceção será disparada.
                if (value == "")
                {
                    throw new ArgumentException("Todas as informações devem ser preenchidas.");
                }

                _nome = value;
            }
        }
        string _tipo;
        public string Tipo 
        {
            get => _tipo;
            
            set
            {
                // Validação para o tipo não ser vazio. Caso o tipo seja vazio uma exceção será disparada.
                if (value == "")
                {
                    throw new ArgumentException("Todas as informações devem ser preenchidas.");
                }

                _tipo = value;
            }
        }

        // Métodos da classe Heroi.
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
                if (Nome == "Naruto")
                {
                    ataque = "rasengan";
                }
                else if (Nome == "Sasuke")
                {
                    ataque = "chidori";
                }
                else
                {
                    ataque = "estilo fogo";
                }
            }

            Console.WriteLine();
            Console.WriteLine($"O {Nome} atacou usando -{ataque}-");
            Console.WriteLine();
        }

        public void Defender()
        {
            string defesa = "";

            if (Tipo == "Mago")
            {
                defesa = "feitiço de barreira";
            }
            else if (Tipo == "Guerreiro")
            {
                defesa = "escudo";
            }
            else if (Tipo == "Monge")
            {
                defesa = "bloqueio";
            }
            else
            {
                if (Nome == "Naruto")
                {
                    defesa = "clone das sombras";
                }
                else if (Nome == "Sasuke")
                {
                    defesa = "susano'o";
                }
                else
                {
                    defesa = "estilo terra";
                }
            }

            Console.WriteLine();
            Console.WriteLine($"O {Nome} defendeu usando -{defesa}-");
            Console.WriteLine();
        }
    }
}