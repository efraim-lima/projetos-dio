using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string nome;
    string email;
    string senha;

// Obtém o email e nome do usuário a partir da entrada do console
    nome = Console.ReadLine();
    email = Console.ReadLine();
    
	  do{
      senha = Console.ReadLine();
      
      Regex senhaForte = new Regex(@"^[a-zA-Z0-9!@#$%^&*()_+-={}[]:;<>,.?/|]{8,}$");
      if (!senhaForte.IsMatch(senha)){
        Console.WriteLine("Sua senha precisa ser forte, " + 
        "ter: \n- ao menos 8 caracteres, \n- letras, \n- números, \n- uma letra maiúscula, \n- símbolos")
      }
      else {
        Console.WriteLine("Senha forte e registrada com sucesso!")
      }
      
    while(true);


// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"Nome: {nome}" +
    					$"Email: {email}");


    }
}