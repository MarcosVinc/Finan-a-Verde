using Entidade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços.Validador
{
    public class ValidacaoUsuario : AbstractValidator<Usuario>
    {
        public ValidacaoUsuario() 
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Telefone).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Senha).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Logim).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
        }
    }
}
