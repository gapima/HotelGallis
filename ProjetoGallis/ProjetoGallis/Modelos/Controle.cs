using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGallis.Modelos
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDownComandos loginDown = new LoginDownComandos();

            tem = loginDown.verificarLogin(login, senha);
            if (!loginDown.mensagem.Equals(""))
            {
                this.mensagem = loginDown.mensagem;
            }
            return tem;
        }

        public bool redefinirSenha(string email)
        {
            return tem;
        }
    }
}
