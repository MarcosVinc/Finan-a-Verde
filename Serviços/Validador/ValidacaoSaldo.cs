using Entidade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços.Validador
{
    public class ValidacaoSaldo : AbstractValidator<Usuario>
    {
        public ValidacaoSaldo()
        {          
            RuleFor(x => x.Saldo).NotNull().NotEmpty();
        }
    }
}
