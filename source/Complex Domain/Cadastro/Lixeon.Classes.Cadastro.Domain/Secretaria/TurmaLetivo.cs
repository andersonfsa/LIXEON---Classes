using System;

namespace Lixeon.Classes.Cadastro.Domain.Secretaria
{
    public class TurmaLetivo
    {
        public Guid TurmaLetivoId { get; private set; }

        public Guid TurmaId { get; private set; }
        public Guid PeriodoLetivoId { get; private set; }
        public bool Ativo { get; private set; }

        #region EF
        public Turma Turma { get; private set; }
        public PeriodoLetivo PeriodoLetivo { get; private set; }
        #endregion
    }
}