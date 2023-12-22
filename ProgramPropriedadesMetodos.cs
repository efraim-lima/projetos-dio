// using System;
// using System.Collections.Generic;

// class Robo
// {
//     public int VelocidadeAtual { get; set; } = 0;
//     public int VelocidadeMaxima { get; }
//     public int VelocidadeMinima { get; }

//     public Robo(int vmin, int vmax)
//     {
//         VelocidadeMinima = vmin;
//         VelocidadeMaxima = vmax;
//         VelocidadeAtual = vmin;
//     }

//     public void Acelerar()
//     {
//         if (VelocidadeAtual < VelocidadeMaxima)
//         {
//             VelocidadeAtual++;
//         }
//     }

//     public void Desacelerar()
//     {
//         if (VelocidadeAtual > VelocidadeMinima)
//         {
//             VelocidadeAtual--;
//         }
//     }

//     // Criei esta função para poder apresentar o resultado no final da execução
//     public void Apresentar(){
//         Console.WriteLine(VelocidadeAtual);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string velocidadesInput = Console.ReadLine();

//         string[] velocidades = velocidadesInput.Split(" ");

//         int vmin = int.Parse(velocidades[0]);
//         int vmax = int.Parse(velocidades[1]);
//         Robo robo = new Robo(vmin, vmax);

//         string comandosInput = Console.ReadLine();

//         List<string> comandos = new List<string>();

//         // fiz este laço para poder iterar sob cada comando da segunda string
//         for (int i = 0; i < comandosInput.Length; i++){
//                 comandos.Add(comandosInput.Substring(i, 1));
               
//                // para determinar qual comando seria adotado usei o switch case
//                 switch(comandos[i]){
//                     case "A":
//                         robo.Acelerar();
//                         break;
//                     case "D":
//                         robo.Desacelerar();
//                         break;
//             }
//         }
//         robo.Apresentar();
//     }
// }