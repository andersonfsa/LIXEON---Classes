using Lixeon.Classes.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lixeon.Classes.Cadastro.Domain.Alunos
{
    public class Aluno
    {
        public Guid AlunoId { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public CPF CPF { get; private set; }

        // Construtor necessário para o EF retornar resultado.
        protected Aluno()
        {

        }

        public Aluno(Guid alunoId, string nome, string cpf, string email)
        {
            AlunoId = alunoId;
            Nome = nome;
            DefinirCPF(cpf);
        }

        #region Validação - Scopes
        public void DefinirCPF(string cpf)
        {
            var myCPF = new CPF(cpf);

            if (this.DefinirCPFAlunoScopeEhValido(myCPF))
                CPF = myCPF;
        }
        #endregion

    }
}
