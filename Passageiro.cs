namespace uberConsole
{
    public class Passageiro : Usuario
    {
        /// <summary>
        /// Metodo para solicitar motorista atraves de string
        /// </summary>
        /// <returns> string "procurando...false."</returns>
        public string SolicitarMotorista(){
            return "Procurando motorista disponiveis....";
        }
        public string Pagar(string statusCorrida){
            if(statusCorrida == "finalizada"){
                return "pagamento feito";
            }
            return "pagamento pendente, corrida não finalizada";
        }
    }
}