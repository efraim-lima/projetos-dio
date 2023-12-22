// using System;

// public class Jogador
// {
//     public string Nome { get; set; }
//     public string Nacionalidade { get; set; }
//     public int Idade { get; set; }
//     public string Posicao { get; set; }

//     public Jogador()
//     {
//     }

//     public void Apresentar(){
//         Console.WriteLine($"Jogador criado!");
//                 Console.WriteLine($"{Nome}");
//                 Console.WriteLine($"{Nacionalidade}");
//                 Console.WriteLine($"{Idade}");
//                 Console.WriteLine($"Posição: {Posicao}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string nome = Console.ReadLine();
//         string nacionalidade = Console.ReadLine();
//         int idade = int.Parse(Console.ReadLine());
//         string posicao = Console.ReadLine();

//         Jogador jogador = new Jogador();
//         jogador.Nome = nome;
//         jogador.Nacionalidade = nacionalidade;
//         jogador.Idade = idade;
//         jogador.Posicao = posicao;
//         jogador.Apresentar();
//     }
// }