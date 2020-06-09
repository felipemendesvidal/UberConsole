using System;

namespace uberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Console.WriteLine("Usuario: ");

            //variavel para armazenar valor e fazer a comparação com os espaços já existentes na classe usuario
            string login = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            //chamando função para fazer validação
            //esse valores armazenados nas variaveis criadas, serão atribuidos  as variaveis de apois dessa fnção
            user.Login(login, senha);
            
            if(user.TokenLogin != "" && user.TokenLogin != null){
                Console.WriteLine("Acesso liberado! Usuário logado");
                Console.WriteLine(user.TokenLogin);
            }else{
                Console.WriteLine("deslogado");
            }

        }
    }
}
