namespace ProjetoInicialWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtNumeroMatricula = new TextBox();
            lblNome = new Label();
            lblCPF = new Label();
            lblTelefone = new Label();
            lblNumeroMatricula = new Label();
            txtCPF = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtDataNascimento = new MaskedTextBox();
            lblDataNascimento = new Label();
            lblNomeDaMae = new Label();
            txtNomeDaMae = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLogradouro = new TextBox();
            lblLogradouro = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblCep = new Label();
            txtCep = new MaskedTextBox();
            lblComplemento = new Label();
            lblBairro = new Label();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblPais = new Label();
            txtPais = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 23);
            txtNome.TabIndex = 0;
            // 
            // txtNumeroMatricula
            // 
            txtNumeroMatricula.Location = new Point(517, 60);
            txtNumeroMatricula.Name = "txtNumeroMatricula";
            txtNumeroMatricula.Size = new Size(119, 23);
            txtNumeroMatricula.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(82, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(401, 42);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 5;
            lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(401, 89);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblNumeroMatricula
            // 
            lblNumeroMatricula.AutoSize = true;
            lblNumeroMatricula.Location = new Point(518, 42);
            lblNumeroMatricula.Name = "lblNumeroMatricula";
            lblNumeroMatricula.Size = new Size(120, 15);
            lblNumeroMatricula.TabIndex = 6;
            lblNumeroMatricula.Text = "Número de Matrícula";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(401, 60);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(94, 23);
            txtCPF.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(401, 107);
            txtTelefone.Mask = "(00)00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(94, 23);
            txtTelefone.TabIndex = 9;
            txtTelefone.ValidatingType = typeof(int);
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(517, 107);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(119, 23);
            txtDataNascimento.TabIndex = 10;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(517, 89);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 11;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblNomeDaMae
            // 
            lblNomeDaMae.AutoSize = true;
            lblNomeDaMae.Location = new Point(83, 89);
            lblNomeDaMae.Name = "lblNomeDaMae";
            lblNomeDaMae.Size = new Size(82, 15);
            lblNomeDaMae.TabIndex = 13;
            lblNomeDaMae.Text = "Nome da Mãe";
            // 
            // txtNomeDaMae
            // 
            txtNomeDaMae.Location = new Point(83, 107);
            txtNomeDaMae.Name = "txtNomeDaMae";
            txtNomeDaMae.Size = new Size(299, 23);
            txtNomeDaMae.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 23);
            txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(83, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(378, 162);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(258, 23);
            txtLogradouro.TabIndex = 16;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(378, 144);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 17;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(82, 197);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(82, 215);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(60, 23);
            txtNumero.TabIndex = 18;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(160, 197);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 21;
            lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(160, 215);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(77, 23);
            txtCep.TabIndex = 22;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(83, 250);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 25;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(363, 250);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 24;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(363, 268);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(114, 23);
            txtBairro.TabIndex = 23;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(83, 268);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(257, 23);
            txtComplemento.TabIndex = 26;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(505, 215);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(131, 23);
            txtCidade.TabIndex = 30;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(505, 197);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 29;
            lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(382, 197);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 28;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(382, 215);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(95, 23);
            txtEstado.TabIndex = 27;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(258, 197);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 32;
            lblPais.Text = "Pais";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(258, 215);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(101, 23);
            txtPais.TabIndex = 31;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(505, 267);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(131, 23);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblPais);
            Controls.Add(txtPais);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(lblEstado);
            Controls.Add(txtEstado);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(txtCep);
            Controls.Add(lblCep);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(txtLogradouro);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblNomeDaMae);
            Controls.Add(txtNomeDaMae);
            Controls.Add(lblDataNascimento);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(lblTelefone);
            Controls.Add(lblNumeroMatricula);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNumeroMatricula);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEstado;
        private TextBox txtNumeroMatricula;
        private Label lblNome;
        private Label lblCPF;
        private Label lblTelefone;
        private Label lblNumeroMatricula;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtDataNascimento;
        private Label lblDataNascimento;
        private Label lblNomeDaMae;
        private TextBox txtNomeDaMae;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLogradouro;
        private Label lblLogradouro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblCep;
        private MaskedTextBox txtCep;
        private Label lblComplemento;
        private Label lblBairro;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblEstado;
        private Label lblPais;
        private TextBox txtPais;
        private Button btnSalvar;
    }
}
