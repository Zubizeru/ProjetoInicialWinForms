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
                MessageBox.Show("Nome Inválido");

            if (!ValidaCpf(txtCPF.Text))
                MessageBox.Show("CPF Inválido");

            if (!ValidaData(txtDataNascimento.Text))
                MessageBox.Show("Data de nascimento inválida");

            if (!ValidaTelefone(txtTelefone.Text))
                MessageBox.Show("Telefone Inválido");

            if (!ValidaEmail(txtEmail.Text))
                MessageBox.Show("Email Inválido");

            //if (!ValidaMatricula(txtNumeroMatricula.Text))
            //    MessageBox.Show("Numero de matricula Inválido");

            //if (!ValidaNomeDaMae(txtNomeDaMae.Text))
            //    MessageBox.Show("Nome da mãe Inválido");

            //if (!ValidaLogradouro(txtLogradouro.Text))
            //    MessageBox.Show("Logradouro Inválido");

            //if (!ValidaNumero(txtNumero.Text))
            //    MessageBox.Show("Numero de Logradouro Inválido");

            //if (!ValidaCep(txtCep.Text))
            //    MessageBox.Show("Cep Inválido");

            //if (!ValidaBairro(txtBairro.Text))
            //    MessageBox.Show("Bairro Inválido");

            //if (!ValidaComplemento(txtComplemento.Text))
            //    MessageBox.Show("Complemento Inválido");

            //if (!ValidaCidade(txtCidade.Text))
            //    MessageBox.Show("Cidade Inválido");

            //if (!ValidaEstado(txtEstado.Text))
            //    MessageBox.Show("Estado Inválido");

            //if (!ValidaPais(txtPais.Text))
            //    MessageBox.Show("Pais Inválido");

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
