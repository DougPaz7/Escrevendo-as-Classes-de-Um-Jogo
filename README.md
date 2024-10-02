# Escrevendo as Classes de Um Jogo
 
## Descrição

Este projeto cria uma classe genérica que representa um herói de uma aventura. A classe possui as seguintes propriedades:

- **Nome**
- **Tipo** (exemplo: guerreiro, mago, monge, ninja)

A classe também tem um método chamado `atacar`, que exibe uma mensagem de ataque personalizada, de acordo com o tipo do herói.

## Requisitos

O método `atacar` deve seguir os seguintes requisitos:

- Exibir a mensagem: `"O {nome} atacou usando {ataque}"`.
- No campo **{tipo}**, será concatenado o tipo do herói.
- No campo **{ataque}**, a descrição varia conforme o tipo, seguindo a tabela abaixo:

  - **Mago**: usou magia
  - **Guerreiro**: usou espada
  - **Monge**: usou artes marciais
  - **Ninja**: usou shuriken

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

```
## Program
```

using Escrevendo_as_Classes_de_Um_Jogo.models;

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

Heroi h = new Heroi(nome, tipo);
h.Atacar();
