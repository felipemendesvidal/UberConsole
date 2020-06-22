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
            //cartao
            Cartao cartao = new Cartao();
            //conta
            Conta conta = new Conta();
            //corrida
            Corrida corrida = new Corrida();
            //pagamento
            Pagamento pagamento = new Pagamento();

            //introdução
            Console.WriteLine("\n----------Huber de Console----------");
            Console.WriteLine("---------- Versão Generica ;) ---------------");
            //menu principal
            string resposta; //armazena a resposta analizada
            do{
                Console.WriteLine("\nEntrar como Motorista(m) / Passageiro (p) / Sair(s) ");
                resposta= Console.ReadLine();
                //loop e menu principal
                switch (resposta){
                    //motorista
                    case "m":
                            Console.Clear();
                            Console.WriteLine("\n----------Cadastro de Motorista----------");
                            Console.WriteLine("\nDigite seu nome: ");
                            piloto.nome = Console.ReadLine();
                            Console.WriteLine("\nQual o seu carro: ");
                            piloto.carro = Console.ReadLine();
                            Console.WriteLine("\nPlaca do seu carro: ");
                            piloto.placa = Console.ReadLine();

                            // da para usar tambem treading.sleep(500);
                            Console.WriteLine("\nprocessando...");
                            pessoa.Delay();
                            Console.WriteLine("cadastro feito com sucesso!");

                            //segundo menu
                            string respMenuDois;
                            do{
                                Console.WriteLine("o que deseja fazer agora: Procurar passageiro(p) / Sair (s)");
                                respMenuDois = Console.ReadLine(); // analise resposta
                                
                                //inicio swct
                                switch(respMenuDois){
                                    case "p":
                                        Console.WriteLine(piloto.ProcurarPassageiro());
                                        pessoa.Delay();

                                        Console.WriteLine("\nPassageiro encontrado: ");
                                        Console.WriteLine(pessoa.MostrarDadosPassageiro());

                                        Console.WriteLine("Aceitar passageiro? s/n");
                                        string respPass = Console.ReadLine();
                                        //inicio swct analise
                                        switch(respPass){
                                            case "s":
                                                Console.WriteLine(piloto.aceitarPassageiro());
                                                Console.WriteLine("\nFim da corrida? s/n");
                                                string respfim1 = Console.ReadLine();
                                                if(respfim1 == "s"){
                                                    Console.WriteLine("Solicitando pagamento....");
                                                    pessoa.Delay();
                                                    Console.WriteLine(piloto.receberPagamento());
                                                    Console.WriteLine("\nObrigado por usar o Huber generico!\nAperte ENTER para sair do programa.");
                                                    Console.Read();
                                                }
                                            break;
                                            case "n":
                                                //loop ate aceitar um
                                                Console.WriteLine("Procurando novo passageiro...");
                                                pessoa.Delay();
                                                Console.WriteLine("\nPassageiro encontrado: ");
                                                Console.WriteLine(pessoa.MostrarDadosPassageiro());
                                                //inicio
                                                do{
                                                  Console.WriteLine("Aceitar novo passageiro: s/n");
                                                  respPass = Console.ReadLine();
                                                }while(respPass != "s");
                                                //fim loop e submenu
                                                if(respPass == "s"){
                                                    Console.WriteLine(piloto.aceitarPassageiro());
                                                    Console.WriteLine("\nFim da corrida? s/n");
                                                    string respfim = Console.ReadLine();

                                                    if(respfim == "s"){
                                                        Console.WriteLine("Solicitando pagamento....");
                                                        pessoa.Delay();
                                                        Console.WriteLine(piloto.receberPagamento());
                                                        Console.WriteLine("\nObrigado por usar o Huber generico!\nAperte ENTER para sair do programa.");
                                                        Console.Read();
                                                    }
                                                }
                                            break;
                                            default:
                                                Console.WriteLine("Opção invalida!");
                                            break;
                                        }
                                        //fim swct analise

                                    break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Opção invalida, tente de novo");
                                    break;
                                }
                                //fim swct
                            }while(respMenuDois != "s" && respMenuDois  != "p");
                    break;
                    //fim motorista

                    //passageiro
                    case "p":
                        //criar menu cadastrar de pessoa
                        Console.WriteLine("----------Cadastrar passageiro----------");
                        Console.WriteLine("Verificamos que esse é seu primeiro acesso, você precisa se Cadastrar: ");
                        //nome
                        Console.WriteLine("\nDigite seu nome: ");
                        user.Nome = Console. ReadLine();

                        //login
                        Console.WriteLine("\nDigite um Usuario: ");
                        user.login = Console.ReadLine();

                        //senha
                        Console.WriteLine("\nDigite sua senha: ");
                        user.senha = Console.ReadLine();

                        Console.WriteLine("\nProcessando...");
                        pessoa.Delay();
                        Console.WriteLine("\nCadastro feito com sucesso");
                        //separador
                        Console.WriteLine("-------------------------------------------------");

                        //inicio menu e loop
                        string pResposta;
                        do{
                            Console.WriteLine("\nO que deseja fazer agora: Login(l) / Sair (s)");
                            pResposta = Console.ReadLine();

                            //inicio analise
                            if(pResposta =="l"){
                            
                                //separador
                                Console.WriteLine("\nLogin Cadastrado:");
                                Console.WriteLine("-------------------");

                                //variaveis criadas para armazenar valor e fazer a comparação com os espaços já existentes na classe usuario
                                Console.WriteLine("\nUsuario: ");
                                string login = Console.ReadLine();

                                Console.WriteLine("\nSenha: ");
                                string senha = Console.ReadLine();

                                //delay
                                Console.WriteLine("processando...");
                                pessoa.Delay();

                                //chamando função para fazer validação
                                //esse valores armazenados nas variaveis criadas, serão atribuidos  as variaveis de apoio dessa fnção
                                user.Login(login, senha);

                                //inicio if analise
                                if(user.TokenLogin != "" && user.TokenLogin != null){
                                    Console.Clear();
                                    Console.WriteLine("Acesso liberado! Usuário: "+user.Nome);
                                    Console.WriteLine(user.TokenLogin);

                                    //cadastro pagamento
                                    Console.WriteLine("\nVocê precisa cadastrar meios de pagamento, vamos la!");
                                    Console.WriteLine("\n");
                                    conta.Cadastrar();
                                    
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine($"Dados cadastrados:\nAgencia: (numero) {conta.Agencia}\nConta corrente: (numero) {conta.ContaCorrente }");
                                    Console.WriteLine("-----------------------------------------");

                                    //cadastro cartao
                                    Console.WriteLine("Vamos cadastrar seu cartão: ");
                                    cartao.Cadastrar();

                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine($"Dados do cartão cadastrado:\nTitular: {cartao.Titular}\nNumero: {cartao.Numero}\nBandeira: {cartao.Bandeira}\nCVV: ****");
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("Cadastro realizado com sucesso");

                                    
                                    //segundo menu
                                    Console.WriteLine("\n O que deseja fazer agora: Procurar motorista(m) / Sair(s): ");
                                    string psresp = Console.ReadLine();

                                    //if inicio
                                    if(psresp == "m"){
                                        Console.WriteLine("\n");
                                        pessoa.SolicitarMotorista();
                                        Console.WriteLine(pessoa.SolicitarMotorista());

                                         //delay
                                        Console.WriteLine("processando...");
                                        pessoa.Delay();

                                        Console.WriteLine("Motorista encontrado:");
                                        Console.WriteLine($"Nome: {piloto.Nome} esta localizado em:{piloto.LocalizacaoAtual}\n");

                                        //localização
                                        Console.WriteLine("Onde voce esta? ");
                                        corrida.LocalInicio = Console.ReadLine();

                                        Console.WriteLine("Para onde vai? ");
                                        corrida.LocalChegada = Console.ReadLine();

                                        Console.WriteLine("Enviando para motorista...");
                                        pessoa.Delay();

                                        Console.WriteLine("Iniciar viagem(y) / desistir(n): ");
                                        string viagemResp = Console.ReadLine();
                                        //analisando resp
                                        if(viagemResp == "y"){
                                            Console.WriteLine("\n");
                                            Console.WriteLine("Aguardando motorista...");
                                            pessoa.Delay();
                                            Console.WriteLine(piloto.aceitarPassageiro());
                                        }else{
                                            Console.WriteLine("vai de 99 então, saindo do programa");
                                            pessoa.Delay();
                                        }
                                        //fim if
                                        Console.WriteLine("\nVocê já chegou? s/n");
                                        string finalViagem = Console.ReadLine();
                                        //inicio analise 
                                         if(finalViagem == "s"){
                                             Console.WriteLine("--------------------");
                                             Console.WriteLine("Local saida: "+corrida.LocalInicio);

                                             Console.WriteLine("Destino: "+corrida.LocalChegada);
                                             Console.WriteLine("Valor da viagem: R$ 500.000,04");
                                             Console.WriteLine("--------------------");
                                            string statusCorrida = "fim";
                                            Console.WriteLine(pessoa.Pagar(statusCorrida));
                                            Console.WriteLine("Aperte ENTER para finalizar o programa");
                                            Console.Read();
                                        }else{
                                            Console.WriteLine("\nnão foi dessa vez... Vá ate o seu banco urgente ;)");
                                        }
                                        //fim if
                                    }else{
                                        Console.WriteLine("resposta errada, finalizando programa...");
                                    }
                                    //if fim
                                }else{
                                 Console.WriteLine("Deslogado..."); 
                                }
                                //fim if analise
                            }
                            //sim analise
                        }while(pResposta != "s" && pResposta != "l");
                        //fim menu e loo
                    break;
                    //fim passageiro

                    //finaliza programa
                    case "s":
                            Console.WriteLine("Saindo....");
                            pessoa.Delay();
                    break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Opção invalida, tente de novo");
                    break;
                }  
            } while (resposta != "s"  && resposta != "p" && resposta != "m");
            //fim loop
        }
    }
}
