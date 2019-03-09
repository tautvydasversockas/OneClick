using FluentValidation;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$CommandValidator : AbstractValidator<$fileinputname$Command>
    {
        public $fileinputname$CommandValidator()
        {
            RuleFor(o => o).NotNull();
        }
    }
}