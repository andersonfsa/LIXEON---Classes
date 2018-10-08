using System;

namespace Lixeon.Classes.Cadastro.Domain.Secretaria
{
    public class PeriodoLetivo
    {
        public Guid PeriodoLetivoId { get; private set; }

        public Guid AnoLetivoId { get; private set; }
        public Guid PeriodoId { get; private set; }
        public Guid DisciplinaId { get; private set; }
        public bool Ativo { get; private set; }

        #region EF
        public AnoLetivo AnoLetivo { get; private set; }
        public Periodo Periodo { get; private set; }
        public Disciplina Disciplina { get; private set; }
        #endregion
    }
}