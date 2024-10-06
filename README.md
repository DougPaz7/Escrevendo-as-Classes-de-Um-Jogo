# Escrevendo as Classes de Um Jogo
 
## Descrição

Este projeto cria uma classe genérica que representa um herói de uma aventura. A classe possui as seguintes propriedades:

- **Nome**
- **Tipo** (exemplo: guerreiro, mago, monge, ninja)

A classe também tem um método chamado `atacar` e um método chamado `defender` que exibe uma mensagem de ataque ou defesa personalizada, de acordo com o tipo do herói.

## Requisitos

O método `atacar` deve seguir os seguintes requisitos:

- Exibir a mensagem: `"O {nome} atacou usando {ataque}"`.
- No campo **{tipo}**, será concatenado o tipo do herói.
- No campo **{ataque}**, a descrição varia conforme o tipo, seguindo a tabela abaixo:

  - **Mago**: usou magia
  - **Guerreiro**: usou espada
  - **Monge**: usou artes marciais
  - **Ninja**: usou shuriken

O método `defender` deve seguir os seguintes requisitos:

- Exibir a mensagem: `"O {nome} defendeu usando {ataque}"`.
- No campo **{tipo}**, será concatenado o tipo do herói.
- No campo **{defesa}**, a descrição varia conforme o tipo, seguindo a tabela abaixo:

  - **Mago**: usou feitiço de barreira
  - **Guerreiro**: usou escudo
  - **Monge**: usou bloqueio
  - **Ninja**: usou estilo terra

## Exemplo de Saída

```plaintext
O mago atacou usando magia.
O guerreiro atacou usando espada.
O monge atacou usando artes marciais.
O ninja atacou usando shuriken.

```
## Classe Herói
```

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

```
## Program
```

using Escrevendo_as_Classes_de_Um_Jogo.models;

// Variável para verificar se o usuário deseja continuar no programa.
string continuar = "";

// Looping para inserir o usuário no programa.
do
{
    Console.Write("Digite o nome do seu herói: ");
    string nome = Console.ReadLine();

    Console.Write(@"
============
|Mago      |
|Guerreiro |
|Monge     | 
|Ninja     |
============
Digite o tipo do seu herói: ");
    string tipo = Console.ReadLine();
 
    Console.Write($"{nome} irá atacar ou defender? [A/D] ");
    string ataqueOuDefesa = Console.ReadLine();

    if (ataqueOuDefesa == "")
    {
        Console.WriteLine("Todas as informações devem ser preenchidas.");
    }
    else if (ataqueOuDefesa == "A")
    {
        // Instância da classe Heroi caso o usuário deseje atacar.
        Heroi h = new Heroi(nome, tipo);
        h.Atacar();
    }
    else
    {
        // Instância da classe Heroi caso o usuário deseje defender.
        Heroi h = new Heroi(nome, tipo);
        h.Defender();
    }

    Console.WriteLine("Deseja continuar? [S/N]");
    continuar = Console.ReadLine();
    Console.Clear();
} while (continuar != "N");
