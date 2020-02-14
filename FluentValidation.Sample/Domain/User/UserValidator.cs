using FluentValidation.Sample.Domain.Pet;

namespace FluentValidation.Sample.Domain.User
{
    public class UserValidator : AbstractValidator<UserEntity>
    {
        public UserValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(o => o.Name).NotEmpty().WithMessage("name not empty")
                              .MinimumLength(2).WithMessage("at least 2 words");
            RuleFor(o => o.Age).NotEmpty().WithMessage("age not empty")
                            .Must(Between18to60).WithMessage("must between 18 to 60");
            //re-use validator
            RuleFor(o => o.Pet).SetValidator(new PetValidator());

            RuleFor(o => o.Phone).Must(o => o.Count > 0).WithMessage("no element")
            //equal to [RuleForEach(o => o.Phone).NotEmpty();]
                .ForEach(o => o.NotEmpty().WithMessage("phone index [{CollectionIndex}] is required"));

        }

        protected bool Between18to60(int age)
        {
            return 18 <= age && age <= 60;
        }
    }
}
