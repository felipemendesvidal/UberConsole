namespace uberConsole
{
    public class Motorista : Usuario
    {
        private string carro;
        private string placa;

        public string aceitarPassageiro(){
            return "passageiro aceito";
        }
        public string receberPagamento(){
            return "pagamento aceito";
        }
    }
}