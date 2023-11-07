using UserLogin.Apresentação;
using UserLogin.Modelo;

namespace UserLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFehcar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controlar = new Controle();
            controlar.acessar(txtLogin.Text, txtSenha.Text);
            if (controlar.mensagem.Equals(""))
            {


                if (controlar.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Acesso acc = new Acesso();
                    acc.Show();
                }

                else
                {
                    MessageBox.Show("Login ou senha incorretos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controlar.mensagem);
            }
        }
    }
}