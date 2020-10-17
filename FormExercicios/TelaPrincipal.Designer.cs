namespace FormExercicios
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.rdFeminino = new System.Windows.Forms.RadioButton();
            this.chboxReceber = new System.Windows.Forms.CheckBox();
            this.lblLogado = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.dtpDataNacimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblValidarEmail = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValidaTel = new System.Windows.Forms.Label();
            this.lblValidarTel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 16;
            this.cboEstado.Location = new System.Drawing.Point(472, 82);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(144, 24);
            this.cboEstado.TabIndex = 6;
            this.cboEstado.Text = "( Selecione )";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMasculino.Location = new System.Drawing.Point(130, 244);
            this.rdMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(96, 20);
            this.rdMasculino.TabIndex = 4;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            this.rdMasculino.CheckedChanged += new System.EventHandler(this.rdMasculino_CheckedChanged);
            // 
            // rdFeminino
            // 
            this.rdFeminino.AutoSize = true;
            this.rdFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFeminino.Location = new System.Drawing.Point(130, 272);
            this.rdFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rdFeminino.Name = "rdFeminino";
            this.rdFeminino.Size = new System.Drawing.Size(89, 20);
            this.rdFeminino.TabIndex = 4;
            this.rdFeminino.TabStop = true;
            this.rdFeminino.Text = "Feminino";
            this.rdFeminino.UseVisualStyleBackColor = true;
            this.rdFeminino.CheckedChanged += new System.EventHandler(this.rdFeminino_CheckedChanged);
            // 
            // chboxReceber
            // 
            this.chboxReceber.AutoSize = true;
            this.chboxReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxReceber.Location = new System.Drawing.Point(106, 332);
            this.chboxReceber.Margin = new System.Windows.Forms.Padding(4);
            this.chboxReceber.Name = "chboxReceber";
            this.chboxReceber.Size = new System.Drawing.Size(290, 24);
            this.chboxReceber.TabIndex = 8;
            this.chboxReceber.Text = "Receber Informações sobre nós.";
            this.chboxReceber.UseVisualStyleBackColor = true;
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.ForeColor = System.Drawing.Color.Red;
            this.lblLogado.Location = new System.Drawing.Point(821, 11);
            this.lblLogado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(85, 16);
            this.lblLogado.TabIndex = 4;
            this.lblLogado.Text = "Deslogado";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(36, 87);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome :";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(13, 170);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 20);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone :";
            this.lblTelefone.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 84);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(393, 86);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(76, 20);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado :";
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(474, 372);
            this.btnSubmeter.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(112, 28);
            this.btnSubmeter.TabIndex = 9;
            this.btnSubmeter.Text = "GRAVAR";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(36, 134);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 130);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(636, 84);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 20);
            this.lblCidade.TabIndex = 14;
            this.lblCidade.Text = "Cidade :";
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.ItemHeight = 16;
            this.cboCidade.Location = new System.Drawing.Point(714, 82);
            this.cboCidade.Margin = new System.Windows.Forms.Padding(4);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(192, 24);
            this.cboCidade.TabIndex = 7;
            this.cboCidade.Text = "(Selecione um Estado)";
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged);
            // 
            // dtpDataNacimento
            // 
            this.dtpDataNacimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNacimento.Location = new System.Drawing.Point(130, 214);
            this.dtpDataNacimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNacimento.Name = "dtpDataNacimento";
            this.dtpDataNacimento.Size = new System.Drawing.Size(112, 22);
            this.dtpDataNacimento.TabIndex = 3;
            this.dtpDataNacimento.Value = new System.DateTime(2020, 10, 13, 0, 0, 0, 0);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(11, 214);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(111, 16);
            this.lblDataNascimento.TabIndex = 16;
            this.lblDataNascimento.Text = "Data de Nasc :";
            this.lblDataNascimento.Click += new System.EventHandler(this.lblDataNascimento_Click);
            // 
            // lblValidarEmail
            // 
            this.lblValidarEmail.AutoSize = true;
            this.lblValidarEmail.Location = new System.Drawing.Point(398, 134);
            this.lblValidarEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidarEmail.Name = "lblValidarEmail";
            this.lblValidarEmail.Size = new System.Drawing.Size(0, 16);
            this.lblValidarEmail.TabIndex = 17;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(106, 171);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(126, 22);
            this.mskTelefone.TabIndex = 2;
            this.mskTelefone.Leave += new System.EventHandler(this.mskTelefone_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(336, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 32);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Cadastro de Cliente";
            // 
            // lblValidaTel
            // 
            this.lblValidaTel.AutoSize = true;
            this.lblValidaTel.Location = new System.Drawing.Point(275, 174);
            this.lblValidaTel.Name = "lblValidaTel";
            this.lblValidaTel.Size = new System.Drawing.Size(0, 16);
            this.lblValidaTel.TabIndex = 19;
            // 
            // lblValidarTel
            // 
            this.lblValidarTel.AutoSize = true;
            this.lblValidarTel.Location = new System.Drawing.Point(275, 174);
            this.lblValidarTel.Name = "lblValidarTel";
            this.lblValidarTel.Size = new System.Drawing.Size(0, 16);
            this.lblValidarTel.TabIndex = 20;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 459);
            this.Controls.Add(this.lblValidarTel);
            this.Controls.Add(this.lblValidaTel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblValidarEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dtpDataNacimento);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.chboxReceber);
            this.Controls.Add(this.rdFeminino);
            this.Controls.Add(this.rdMasculino);
            this.Controls.Add(this.cboEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.RadioButton rdFeminino;
        private System.Windows.Forms.CheckBox chboxReceber;
        private System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.DateTimePicker dtpDataNacimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblValidarEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValidaTel;
        private System.Windows.Forms.Label lblValidarTel;
    }
}