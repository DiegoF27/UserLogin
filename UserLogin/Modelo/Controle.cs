using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.DAL;

namespace UserLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        
        public bool acessar(String login, String senha)
        {
            LoginComandos loginCmd = new LoginComandos();
            tem = loginCmd.verificarLogin(login, senha);
            if (!loginCmd.mensagem.Equals(""))
            {
                this.mensagem = loginCmd.mensagem;
            }
            return tem;
        }
        public String cadastrar(String email, String cpf, String senha, String confsenha) 
        {
            return mensagem;
        }
    }   

}
