﻿namespace ProjetoInicialWinForms.Model
{
    public class AlunoModel
    {
        public string Nome { get; set; }

        public string NumeroMatricula { get; set; }

        public int CPF { get; set; }

        public int Telefone { get; set; }

        public EnderecoModel EnderecoAluno { get; set; }

        public string DataNascimento { get; set; }

        public string NomeDaMae { get; set; }

        public string Email { get; set; }
    }
}
