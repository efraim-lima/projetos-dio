// using System;

// class Program
// {
//     static void Main()
//     {
//         // Solicita o nome do usuário, quilômetros percorridos por dia, 
//         // Horas de uso de eletrônicos por dia e o número de refeições com carne:
//         string nome = Console.ReadLine();
//         double quilometrosPorDia = double.Parse(Console.ReadLine());
//         int horasDeEletronicos = int.Parse(Console.ReadLine());
//         int refeicoesComCarne = int.Parse(Console.ReadLine());

//             // Chama o método para calcular a pegada de carbono
//             double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
            
//             // IMPLEMENTADO
//             Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

//             // Aguarda a entrada do usuário antes de encerrar o programa:
//             Console.ReadLine();
//     }

//     // IMPLEMENTADO
//     static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne){
//         double quilometros = quilometrosPorDia * 365 * 0.2;
//         double horas = horasDeEletronicos * 0.1;
//         double refeicoes = refeicoesComCarne * 0.5;
//         double pegadaCarbono = quilometros + horas + refeicoes;
//         return pegadaCarbono;
//     }

// }