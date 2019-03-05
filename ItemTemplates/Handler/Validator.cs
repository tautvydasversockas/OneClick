using FluentValidation;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$Validator : AbstractValidator<MyMessage>
    {
        public $fileinputname$Validator()
        {
            RuleFor(o => o).NotNull();
        }
    }
}