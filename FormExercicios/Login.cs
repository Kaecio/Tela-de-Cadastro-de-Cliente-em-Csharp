using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExercicios
{
    public partial class Login : Form
    {
        string nome = "kaecio";
        string senha = "123";

        public Login()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string caixaNome = txtNome.Text;
            string caixaSenha = txtSenha.Text;
            if (caixaNome == nome && caixaSenha == senha )
            {
                
                TelaPrincipal tela = new TelaPrincipal(caixaNome);
                tela.ShowDialog();
                
                //Login login = new Login();
                //login.Close();
                
            }
            else if (string.IsNullOrEmpty(caixaNome) || string.IsNullOrEmpty(caixaSenha))
            {
                MessageBox.Show("Você esqueceu algum campo vazio. Vamos tentar de novo! ");
            }
            else if (caixaNome != nome && caixaSenha != senha)
            {
                MessageBox.Show("Nome ou senha inválida, tente novamente!");
            }
           
            
            txtNome.Text = string.Empty; 
            txtSenha.Text = string.Empty;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
