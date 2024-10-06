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