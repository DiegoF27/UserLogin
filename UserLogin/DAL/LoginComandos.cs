using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin.DAL
{
    internal class LoginComandos
    {
        public bool tem = false;
        public String mensagem = ""; // se msg vazia está tudo ok 
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            // comandos sql para verificar se tem no banco.
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conecta();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
            
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }

            return tem;
        }

        public String cadastrar(String email, String cpf, String senha, String confsenha)
        {
            // comandos para inserir no banco retornado uma string com "cadastrado" ou "erro"
            return mensagem;
        }
    }
}
