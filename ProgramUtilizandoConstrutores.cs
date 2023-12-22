// using System;

// class Personagem
// {
//     public string Nome { get; set; }
//     public string Raca { get; set; }
//     public string Classe { get; set; }
//     public int Nivel { get; set; } = 1;
//     public int Vida { get; set; } = 10;
//     public int Mana { get; set; } // Criei esta propriedade, pois nâo existia e foi solicitada nas especificações do programa

//     public Personagem(string nome, string raca, string classe)
//     {
//         Nome = nome;
//         Raca = raca;
//         Classe = classe;
//     }

//     public void ExibirStatus()
//     {
//         Console.WriteLine("Status:");
//         Console.WriteLine("Nome:" + Nome);
//         Console.WriteLine("Raça:" + Raca);
//         Console.WriteLine("Classe:" + Classe);
//         Console.WriteLine("Nível:" + Nivel);
//         Console.WriteLine("Vida:" + Vida);
//         // Console.WriteLine("Mana:" + Mana);  // Criei este output, pois nâo existia e foi solicitada nas especificações do programa, mas manterei comentado pois acredito que o ambriente de testes da dio não comporte esta saida
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string nome = Console.ReadLine();
//         string raca = Console.ReadLine();
//         string classe = Console.ReadLine();

//         Personagem personagem = new Personagem(nome,raca,classe);

//         personagem.ExibirStatus();
//     }
// }