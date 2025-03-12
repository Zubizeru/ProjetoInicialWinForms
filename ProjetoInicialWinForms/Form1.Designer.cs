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
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 23);
            txtNome.TabIndex = 0;
            // 
            // txtNumeroMatricula
            // 
            txtNumeroMatricula.Location = new Point(111, 92);
            txtNumeroMatricula.Name = "txtNumeroMatricula";
            txtNumeroMatricula.Size = new Size(159, 23);
            txtNumeroMatricula.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 74);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 5;
            lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(292, 74);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblNumeroMatricula
            // 
            lblNumeroMatricula.AutoSize = true;
            lblNumeroMatricula.Location = new Point(112, 74);
            lblNumeroMatricula.Name = "lblNumeroMatricula";
            lblNumeroMatricula.Size = new Size(120, 15);
            lblNumeroMatricula.TabIndex = 6;
            lblNumeroMatricula.Text = "Número de Matrícula";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 92);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(76, 23);
            txtCPF.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(292, 92);
            txtTelefone.Mask = "(00)00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(115, 23);
            txtTelefone.TabIndex = 9;
            txtTelefone.ValidatingType = typeof(int);
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(12, 151);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(114, 23);
            txtDataNascimento.TabIndex = 10;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(12, 133);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 11;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblNomeDaMae
            // 
            lblNomeDaMae.AutoSize = true;
            lblNomeDaMae.Location = new Point(150, 133);
            lblNomeDaMae.Name = "lblNomeDaMae";
            lblNomeDaMae.Size = new Size(82, 15);
            lblNomeDaMae.TabIndex = 13;
            lblNomeDaMae.Text = "Nome da Mãe";
            // 
            // txtNomeDaMae
            // 
            txtNomeDaMae.Location = new Point(150, 151);
            txtNomeDaMae.Name = "txtNomeDaMae";
            txtNomeDaMae.Size = new Size(257, 23);
            txtNomeDaMae.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(395, 23);
            txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 194);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox textBox2;
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
    }
}
