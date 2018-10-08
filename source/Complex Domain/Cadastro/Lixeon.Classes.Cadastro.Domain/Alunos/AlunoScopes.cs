using Lixeon.Classes.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lixeon.Classes.Cadastro.Domain.Alunos
{
    public static class AlunoScopes
    {
        public static bool DefinirCPFAlunoScopeEhValido(this Aluno aluno, CPF cpf)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertFixedLength(cpf.Codigo, CPF.ValorMaxCpf, "CPF em tamanho incorreto"),
                AssertionConcern.AssertNotNullOrEmpty(cpf.Codigo, "CPF obrigatória"),
                AssertionConcern.AssertTrue(CPF.Validar(cpf.Codigo), "CPF em formato inválido")
            );
        }
    }
}
