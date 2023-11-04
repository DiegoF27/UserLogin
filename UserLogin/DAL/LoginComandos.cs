using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin.DAL
{
    internal class LoginComandos
    {
        public bool tem;
        public String mensagem = "";
        public bool verificarLogin(String Login, String senha)
        {
            // comandos sql para verificar se tem no banco.
            return tem;
        }

        public String cadastrar(String email, String cpf, String senha, String confsenha)
        {
            // comandos para inserir no banco retornado uma string com "cadastrado" ou "erro"
            return mensagem;
        }
    }
}
