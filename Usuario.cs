namespace uberConsole
{
    public class Usuario
    {
        public string Nome {get; set;}
        public string login;
        public string senha;
        public string Foto {get; set;}
        public string LocalizacaoAtual{get; set;}
        public string TokenLogin{get; set;}

        /// <summary>
        /// Metodo que valida login
        /// verifica if(this.login == login && this.senha == senha)
        /// </summary>
        /// <param name="loginAtributo">pega dados</param>
        /// <param name="senhaAtributo">pega dados</param>
        /// <returns>retorna em = TokenLogin = "senha ok";</returns>
        public bool Login(string loginAtributo, string senhaAtributo){
            if(this.login == loginAtributo && this.senha == senhaAtributo){
                TokenLogin = "senha ok";
                return true;
            }
            return false;
        }
        public void Logout(){
            TokenLogin = "";
        }
    }
}