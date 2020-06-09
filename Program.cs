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
            Console.WriteLine("\n");
            
            //passageiro
            Passageiro pessoa = new Passageiro();

            if(user.TokenLogin == "senha ok" ){
                Console.WriteLine("O que deseja fazer: P(Procurar Motorista) S(sair)");
                string resposta = Console.ReadLine();

                //switc analise da resposta
                switch(resposta){
                    case "P": 
                        Console.WriteLine(pessoa.SolicitarMotorista());
                    break;

                    case "S":
                        Console.WriteLine("testando funciona");
                    break;
                    default:
                        Console.WriteLine("opção invalida, finalizando ...");
                    break;
                }
                //fim swic
                

            }else{
                Console.WriteLine("teste2");
            }

        }
    }
}
