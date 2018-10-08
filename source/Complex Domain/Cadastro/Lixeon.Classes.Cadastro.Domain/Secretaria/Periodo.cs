﻿using System;

namespace Lixeon.Classes.Cadastro.Domain.Secretaria
{
    public class Periodo
    {
        public Guid PeriodoId { get; private set; }

        public Guid CursoId { get; private set; }
        public string CodExterno { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        #region EF
        public Curso Curso { get; private set; }
        #endregion
    }
}