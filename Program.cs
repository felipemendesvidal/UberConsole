// Programa que simula aplicativo de mobilidade urbana exemplo uber
//Por: Felipe Vidal
using System;
//para usar delay
using System.Threading.Tasks;

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

            //introdução
            Console.WriteLine("----------Uber de Console----------");


            //criar menu cadastrar de pessoa
            Console.WriteLine("Primeiro acesso, você precisa se Cadastrar:");
            
            Console.WriteLine("\nDigite um Usuario: ");
            user.login = Console.ReadLine();
    
            Console.WriteLine("\nDigite sua senha: ");
            user.senha = Console.ReadLine();
            Console.WriteLine("\nProcessando...");
            // anotação de delay forma feia de se usar delay
            var processo1 = Task.Run( async delegate{
                 await Task.Delay(2000);
                 return 47;
            });
            processo1.Wait();

            Console.WriteLine("\nCadastro feito com sucesso");
            //separador
            Console.WriteLine("-------------------------------------------------");

            //priemro menu
            Console.WriteLine("\nO que deseja fazer agora: Login(l) / Sair (s)");
            string resposta = Console.ReadLine();
            
            //separador
            Console.WriteLine("\nLogin Cadastrado:");
            Console.WriteLine("-------------------");
            
            //inicio if
            if(resposta == "l"){
                //variaveis criadas para armazenar valor e fazer a comparação com os espaços já existentes na classe usuario
                Console.WriteLine("\nUsuario: ");
                string login = Console.ReadLine();

                Console.WriteLine("\nSenha: ");
                string senha = Console.ReadLine();
                //delay
                Console.WriteLine("processando...");
                // anotação de delay forma feia de se usar delay
                var processo2 = Task.Run( async delegate{
                    await Task.Delay(2000);
                    return 47;
                });
                processo2.Wait();

                //chamando função para fazer validação
                //esse valores armazenados nas variaveis criadas, serão atribuidos  as variaveis de apoio dessa fnção
                 user.Login(login, senha);
                    
                if(user.TokenLogin != "" && user.TokenLogin != null){
                    Console.Clear();

                    Console.WriteLine("Acesso liberado! Usuário logado");
                    Console.WriteLine(user.TokenLogin);

                    //FALTA FAZER: cadastrar forma de pagamento, perguntar qual vai ser a forma pagamento, criação da classe pagamnto

                    //segundo menu
                    Console.WriteLine("\n O que deseja fazer agora: Procurar motorista(m) / Sair(s): ");
                    resposta = Console.ReadLine();

                    if(resposta == "m"){
                        Console.WriteLine("\n");
                        pessoa.SolicitarMotorista();
                        Console.WriteLine(pessoa.SolicitarMotorista());

                        //delay
                        Console.WriteLine("processando...");
                        // anotação de delay forma feia de se usar delay
                        var processo3 = Task.Run( async delegate{
                            await Task.Delay(2000);
                            return 47;
                        });
                        processo3.Wait();

                        Console.WriteLine("Motorista encontrado:");
                        Console.WriteLine($"Nome: {piloto.Nome} esta localizado em:{piloto.LocalizacaoAtual}\n");

                        Console.WriteLine("Iniciar viagem(y) / desistir(n): ");
                        string viagemResp = Console.ReadLine();

                        //if inicio analisando resp
                        if(viagemResp == "y"){
                            Console.WriteLine("\n");
                            Console.WriteLine("Aguardando motorista...");
                             //delay
                            // anotação de delay forma feia de se usar delay
                            var processo4 = Task.Run( async delegate{
                                await Task.Delay(2000);
                                return 47;
                            });
                            processo4.Wait();

                            Console.WriteLine(piloto.aceitarPassageiro());

                            //FALTA FAZER: calc de quando vai ser a viagem, mostrar na tela, perguntar se aceita ou desiste

                            Console.WriteLine("Finalizar viagem: s/n");
                            string finalViagem = Console.ReadLine();
                            
                            //inicio analise 
                            if(finalViagem == "s"){
                                string statusCorrida = "fim";
                                Console.WriteLine(pessoa.Pagar(statusCorrida));
                                Console.WriteLine("Aperte ENTER para finalizar o programa");
                                Console.Read();
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
            Console.Clear();
        }
    }
}
