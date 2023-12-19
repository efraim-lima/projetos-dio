// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main(string[] args)
//     {
//     // IMPLEMENTADO
//     string registroNome;
//     string registroEmail;
//     string registroSenha;
    
//     // IMPLEMENTADO
//     registroNome = Console.ReadLine();
//     registroEmail = Console.ReadLine();
//     registroSenha = Console.ReadLine();

//     //IMPLEMENTADO
//     Console.WriteLine($"{registroNome}, verifique o email: {registroEmail}" );
    
//     // IMPLEMENTADO
//     string nome;
//     string email;
//     string senha;

//     // IMPLEMENTADO
//     //Por segurança inseri uma validador de senha e email, para que ela atenda a algumas regras de qualidade, 
//     //mais interessante ainda seria fazer a sanitização dos inputs também, mas não caberia neste projeto
   
//     Console.WriteLine("Digite seu nome: ");
//     nome = Console.ReadLine();
    
//     do{
//         Console.WriteLine("Digite um email válido: ");
//         email = Console.ReadLine();
        
//         Regex emailValido = new Regex(@"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$");
        
//         if (emailValido.IsMatch(email)){
//             Console.WriteLine("Email validado!\n\n");
//             break;
//         }
//         else {
//             Console.WriteLine("Email inválido! \nEmail precisa atender aos requisitos: email@email.com\n\n");
//         }
//     } while(true);
    
    
//     do{
//     Console.WriteLine("Digite uma senha forte: ");
//     senha = Console.ReadLine();
    
//     Regex senhaForte = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$");
    
//     if (senhaForte.IsMatch(senha)){
//         Console.WriteLine("Senha forte e registrada com sucesso!\n\n");
//         break;
//     }
//     else {
//         Console.WriteLine("Sua senha precisa ser forte, " + 
//         "ter: \n- ao menos 8 caracteres, \n- ao menos 1 letra minuscula, \n- ao menos 1 número, \n- ao menos 1 letra maiúscula, \n- ao menos um símbolo\n\n");
//     }
//     } while(true);

//     // IMPLEMENTADO
//     Console.WriteLine($"{nome}, verifique o email: \n{email}");
//   }

// }


// /*
// // Solução que havia feito anteriormente, rodou em meu ambiente, mas não funcionou aqui no ambiente de testes da plataforma. */