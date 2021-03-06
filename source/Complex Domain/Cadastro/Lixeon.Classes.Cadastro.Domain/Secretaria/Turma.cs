﻿using System;

namespace Lixeon.Classes.Cadastro.Domain.Secretaria
{
    public class Turma
    {
        public Guid TurmaId { get; private set; }

        public Guid PeriodoId { get; private set; }

        public string CodExterno { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        #region EF
        public Periodo Periodo { get; private set; }
        #endregion
    }
}