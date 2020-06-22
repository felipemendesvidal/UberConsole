using System;
namespace uberConsole
{
    public class Motorista : Usuario
    {
        public string nome;
        public string carro;
        public string placa;

        public string aceitarPassageiro(){
            return "passageiro aceito";
        }
        public string receberPagamento(){
            return "pagamento aceito";
        }
        public string ProcurarPassageiro(){
            return "Procurando passageiro...";
        }
    }
}