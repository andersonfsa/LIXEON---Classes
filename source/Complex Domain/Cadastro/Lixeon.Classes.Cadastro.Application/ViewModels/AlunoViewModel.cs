using System;

namespace Lixeon.Classes.Cadastro.Application.ViewModels
{
    public class AlunoViewModel
    {
        public AlunoViewModel()
        {
            AlunoId = Guid.NewGuid();
        }

        public Guid AlunoId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}
