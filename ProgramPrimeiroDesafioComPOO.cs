// using System;

// class Pessoa
// {
 


//     public Pessoa(string n, int i)
//     {
//         string nome = n;
//         int idade = i;
//         // Utilizando para garantir o output da classe
//         Console.WriteLine($"Nome: {nome}, Idade: {idade}");
//     }

//     // Fundamental para poder inicializar a instancia dentro do Program sem precisar passar atributos
//     public Pessoa(){

//     }

//     public string GetNome()
//     {
//         // Aqui vamos capturar o input do usuário      
//         string nome = Console.ReadLine();
//         return nome;
//     }

//     public int GetIdade()
//     {
//         // Aqui vamos capturar o input do usuário
//         int idade = int.Parse(Console.ReadLine());
//         return idade;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Instanciando Pessoa() para podermos utilizar os métodos presentes em seu escopo
//         Pessoa p1 = new Pessoa();
//         // Inicializando os métodos da classe Pessoa() e armazenando em variaveis para serem reutilizadas
//         string n = p1.GetNome(); 
//         int i = p1.GetIdade();
        
//         // Transferindo as variaveis n e i como atributos para a classe Pessoa trabalhar com elas
//         new Pessoa(n,i);
//     }
// }