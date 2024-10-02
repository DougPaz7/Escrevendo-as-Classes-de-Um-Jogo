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