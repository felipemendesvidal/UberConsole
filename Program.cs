// Programa que simula aplicativo de mobilidade urbana exemplo uber
//Por: Felipe Vidal
using System;

namespace uberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //usuario
            Usuario user = new Usuario();
            //passageiro
            Passageiro pessoa = new Passageiro();

            //criar menu cadastrar de pessoa
            Console.WriteLine("Primeiro acesso, você precisa se Cadastrar:");
            
            Console.WriteLine("\n Digite um Usuario: ");
            user.login = Console.ReadLine();
    
            Console.WriteLine("\nDigite sua senha: ");
            user.senha = Console.ReadLine();

            Console.WriteLine("\nCadastro feito com sucesso");
            //priemro menu
            Console.WriteLine("\nO que deseja fazer agora: Login(l) / Sair (s)");
            string resposta = Console.ReadLine();

            //inicio if
            if(resposta == "l"){
                //variaveis criadas para armazenar valor e fazer a comparação com os espaços já existentes na classe usuario
                Console.WriteLine("\nUsuario: ");
                string login = Console.ReadLine();

                Console.WriteLine("\nSenha: ");
                string senha = Console.ReadLine();

                //chamando função para fazer validação
                //esse valores armazenados nas variaveis criadas, serão atribuidos  as variaveis de apoio dessa fnção
                 user.Login(login, senha);
                    
                if(user.TokenLogin != "" && user.TokenLogin != null){
                    Console.WriteLine("Acesso liberado! Usuário logado");
                    Console.WriteLine(user.TokenLogin);
                }else{
                    Console.WriteLine("deslogado");
                }

                Console.WriteLine("\n");
            }
            //fim if
        }
    }
}
