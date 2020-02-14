using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Sample.Domain.Pet
{
    public class PetValidator : AbstractValidator<PetEntity>
    {
        public PetValidator()
        {
            RuleFor(o => o.NickName).NotEmpty().WithMessage("not empty");
            RuleFor(o => o.Type).NotEqual((byte)0).WithMessage("no type specified");
        }
    }
}
