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
            //motorista
            Motorista piloto = new Motorista();
            piloto.Nome = "armando";
            piloto.LocalizacaoAtual ="rua bem ali 123";

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
                    Console.Clear();

                    Console.WriteLine("Acesso liberado! Usuário logado");
                    Console.WriteLine(user.TokenLogin);

                    //segundo menu
                    Console.WriteLine("\n O que deseja fazer agora: Procurar motorista(m) / Sair(s): ");
                    resposta = Console.ReadLine();

                    if(resposta == "m"){
                        Console.WriteLine("\n");
                        pessoa.SolicitarMotorista();
                        Console.WriteLine(pessoa.SolicitarMotorista());
                        Console.WriteLine("Motorista encontrado:");
                        Console.WriteLine($"Nome: {piloto.Nome} esta localizado em:{piloto.LocalizacaoAtual}\n");

                        Console.WriteLine("Iniciar viagem(y) / desistir(n): ");
                        string viagemResp = Console.ReadLine();

                        //if inicio analisando resp
                        if(viagemResp == "y"){
                            Console.WriteLine(piloto.aceitarPassageiro());

                            Console.WriteLine("Finalizar viagem: s/n");
                            string finalViagem = Console.ReadLine();
                            
                            //inicio analise 
                            if(finalViagem == "s"){
                                string statusCorrida = "fim";
                                Console.WriteLine(pessoa.Pagar(statusCorrida));
                            }else{
                                Console.WriteLine("\nnão foi dessa vez... teste");
                            }
                            //fim analise

                        }else{
                            Console.WriteLine("viagem cancelada");
                        }


                        

                    }else{
                        Console.WriteLine("Saindo do programa");
                    }

                }else{
                    Console.WriteLine("deslogado...");
                }
            }else{
                Console.WriteLine("Obrigado por usar o programa");
            }
            //fim if
        }
    }
}
