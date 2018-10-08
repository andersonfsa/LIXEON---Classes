using System;

namespace Lixeon.Classes.Cadastro.Domain.Secretaria
{
    public class AnoLetivo
    {
        public Guid AnoLetivoId { get; private set; }

        public string CodExterno { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
    }
}