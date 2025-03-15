using System.Text.RegularExpressions;

namespace ProjetoInicialWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaNome(txtNome.Text))
                MessageBox.Show("Nome Inv�lido");

            if (!ValidaCpf(txtCPF.Text))
                MessageBox.Show("CPF Inv�lido");

            if (!ValidaData(txtDataNascimento.Text))
                MessageBox.Show("Data de nascimento inv�lida");

            if (!ValidaTelefone(txtTelefone.Text))
                MessageBox.Show("Telefone Inv�lido");

            if (!ValidaEmail(txtEmail.Text))
                MessageBox.Show("Email Inv�lido");

            //if (!ValidaMatricula(txtNumeroMatricula.Text))
            //    MessageBox.Show("Numero de matricula Inv�lido");

            //if (!ValidaNomeDaMae(txtNomeDaMae.Text))
            //    MessageBox.Show("Nome da m�e Inv�lido");

            //if (!ValidaLogradouro(txtLogradouro.Text))
            //    MessageBox.Show("Logradouro Inv�lido");

            //if (!ValidaNumero(txtNumero.Text))
            //    MessageBox.Show("Numero de Logradouro Inv�lido");

            //if (!ValidaCep(txtCep.Text))
            //    MessageBox.Show("Cep Inv�lido");

            //if (!ValidaBairro(txtBairro.Text))
            //    MessageBox.Show("Bairro Inv�lido");

            //if (!ValidaComplemento(txtComplemento.Text))
            //    MessageBox.Show("Complemento Inv�lido");

            //if (!ValidaCidade(txtCidade.Text))
            //    MessageBox.Show("Cidade Inv�lido");

            //if (!ValidaEstado(txtEstado.Text))
            //    MessageBox.Show("Estado Inv�lido");

            //if (!ValidaPais(txtPais.Text))
            //    MessageBox.Show("Pais Inv�lido");

    }

        private bool ValidaNome(string nome)
        {
            if (nome == null || nome.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private bool ValidaCpf(string cpf)
        {
            cpf = cpf.Remove(3, 1);
            cpf = cpf.Remove(6, 1);
            cpf = cpf.Remove(9, 1);

            if (cpf == null || cpf.Trim() == "" || !cpf.All(char.IsDigit) || cpf.Length != 11)
            {
                return false;
            }
            return true;
        }

        private bool ValidaData(string DataNascimento)
        {
            DateTime hoje = DateTime.Now;
            DateTime nascimento;

            bool sucesso = DateTime.TryParse(DataNascimento, out nascimento);

            if (!sucesso || nascimento > hoje)
            {
                return false;
            }
            return true;
        }

        private bool ValidaTelefone(string telefone)
        {
            telefone = telefone.Remove(0, 1);
            telefone = telefone.Remove(3, 1);
            telefone = telefone.Remove(7, 1);

            if (telefone == null || telefone.Trim() == "" || !telefone.All(char.IsDigit) || telefone.Length != 11)
            {
                return false;
            }
            return true;
        }

        private bool ValidaEmail(string email)
        {
            if (email == null || email.Trim() == "" || !Regex.IsMatch(email, "/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/"))
            {
                return false;
            }
            return true;
        }
    }
}
