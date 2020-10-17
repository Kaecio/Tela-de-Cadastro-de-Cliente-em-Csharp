using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormExercicios
{
    
    public partial class TelaPrincipal : Form
    {
       
        private string s_nome;
        public TelaPrincipal(string nome)
        {
            InitializeComponent();
            s_nome = nome;
        }

        public class Estado
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return this.Nome;
            }
            public static List<Estado> Lista()
            {
                var lista = new List<Estado>();
                var state = new Estado();
                state.Id = 1;
                state.Nome = "Minas Gerais";
                lista.Add(state);

                state = new Estado();
                state.Id = 2;
                state.Nome = "Rio de Janeiro";
                lista.Add(state);

                state = new Estado();
                state.Id = 3;
                state.Nome = "São Paulo";
                lista.Add(state);

                return lista;
            }
        }

        // classe de cidade

        public class Cidade
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public int IdEstado { get; set; }
            public override string ToString()
            {
                return this.Nome;
            }
            public static List<Cidade> Lista()
            {
                var lista = new List<Cidade>();
                var cidade = new Cidade();
                cidade.Id = 1;
                cidade.IdEstado = 1;
                cidade.Nome = "Belo Horizonte";
                lista.Add(cidade);

                cidade = new Cidade();
                cidade.Id = 2;
                cidade.IdEstado = 1;
                cidade.Nome = "Cambuí";
                lista.Add(cidade);

                cidade = new Cidade();
                cidade.Id = 3;
                cidade.IdEstado = 1;
                cidade.Nome = "Extrema";
                lista.Add(cidade);

                cidade = new Cidade();
                cidade.Id = 4;
                cidade.IdEstado = 2;
                cidade.Nome = "Paraty";
                lista.Add(cidade);


                cidade = new Cidade();
                cidade.Id = 5;
                cidade.IdEstado = 2;
                cidade.Nome = "Niterói";
                lista.Add(cidade);

                cidade = new Cidade();
                cidade.Id = 6;
                cidade.IdEstado = 2;
                cidade.Nome = "Macaé";
                lista.Add(cidade);

                cidade = new Cidade();
                cidade.Id = 7;
                cidade.IdEstado = 3;
                cidade.Nome = "Santo Andre";
                lista.Add(cidade);

           
                cidade = new Cidade();
                cidade.Id = 8;
                cidade.IdEstado = 3;
                cidade.Nome = "Bauru";
                lista.Add(cidade);

              
                cidade = new Cidade();
                cidade.Id = 9;
                cidade.IdEstado = 3;
                cidade.Nome = "Guarulhos";
                lista.Add(cidade);

                return lista;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;
            string sexo = "";
            string estado = cboEstado.Text;
            string dtNacimento = dtpDataNacimento.Value.ToString("dd-MM-yyyy");
            string lblMsgValidEmail = lblValidarEmail.Text;
            string cidade = cboCidade.Text;


            ValidaEmail(email);
            ValidaTelefone(telefone);
  

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Os campos NOME ou TELEFONE ou EMAIL vazio");
                Application.Exit();
            }
            
            if (rdFeminino.Checked == true)
            {
                sexo = "Feminino";
            }
            else if(rdMasculino.Checked == true)
            {
                sexo = "Masculino";
            }

            MessageBox.Show(nome + "\n" + "Estado :" + estado + "\n" + "Cidade :" + cidade + "\n" + "genero : " + sexo + "\n" + "Data nasc :"  + dtNacimento );

            if (chboxReceber.Checked)
            {
                
                MessageBox.Show("Informaçoes serão enviadas para o email " + email);
                MessageBox.Show("Seu cadastro foi realizado com sucesso" +
                                "\n" + "ligaremos para o numero" + telefone);
            }
            else
            {
                MessageBox.Show( "Seu cadastro foi realizado com sucesso," + 
                                "\n" + "ligaremos para o numero" + telefone);
            }

            this.Close();
        }

        private void ValidaEmail(string email)
        {
            Regex emailValido = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (emailValido.IsMatch(email))
            {
                lblValidarEmail.Text = "valido";
            }
            else
            {
                lblValidarEmail.Text = "inválido";
               
            }
        }

        private void ValidaTelefone(string telefone)
        {
            //Regex telefoneValido = new Regex(@"^\(?[1 - 9]{ 2 }\)? ?(?:[2 - 8] | 9[1 - 9])[0 - 9]{ 3}\-?[0 - 9]{ 4}$");
            Regex telefoneValido = new Regex(@"/ ^\([0 - 9]{ 2 }\) [0 - 9]?[0 - 9]{ 4}$/");
            if (telefoneValido.IsMatch(telefone))
            {
                lblValidarTel.Text = "valido";
            }
            else
            {
                lblValidarTel.Text = "inválido";

            }
        }
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lblLogado.Text = s_nome + " Logado";

            cboEstado.Items.Clear(); // não duplica o combobox
            foreach (Estado estado in Estado.Lista())
            {
                cboEstado.Items.Add(estado);
            }

            
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // obter o estado selecionado
            Estado est = (Estado)cboEstado.SelectedItem;
            // obter o id do estado selecionado
            List<Cidade> cid = Cidade.Lista().Where(el => el.IdEstado == est.Id).ToList();
            // filtar a cidade para o estado selecionado
            // limpar a lista de cidade
            cboCidade.Items.Clear();
            // popular o combo com as cidades filtradas
            foreach (Cidade item in cid)
            {
                cboCidade.Items.Add(item);
               cboCidade.Text = "";
            }
            
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rdMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidaEmail(txtEmail.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            ValidaTelefone(mskTelefone.Text);
        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
