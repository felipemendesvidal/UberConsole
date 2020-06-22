using System;
using System.Threading.Tasks;
namespace uberConsole
{
    public class Passageiro : Usuario
    {
        //dados genericos para o motorista
        public string nome = "Geraldo de rivia";

        /// <summary>
        /// Metodo para solicitar motorista atraves de string
        /// </summary>
        /// <returns> string "procurando...false."</returns>
        public string SolicitarMotorista(){
            return "Procurando motorista disponiveis....";
        }
        public string Pagar(string statusCorrida){
            if(statusCorrida == "fim"){
                return "pagamento feito";
            }
            return "pagamento pendente, corrida não finalizada";
        }
        //delay
        public void Delay(){
            var delay = Task.Run( async delegate{
                 await Task.Delay(2000);
                 return 47;
            });
            delay.Wait();
        }
        //mostra dados genericos do passageiro 
        public string MostrarDadosPassageiro(){
            return $"Nome: {nome}";
        }
        
    }
}