using FluentValidation;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$RequestValidator : AbstractValidator<$fileinputname$Request>
    {
        public $fileinputname$RequestValidator()
        {
            RuleFor(o => o).NotNull();
        }
    }
}