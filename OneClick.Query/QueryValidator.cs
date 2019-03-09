using FluentValidation;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$QueryValidator : AbstractValidator<$fileinputname$Query>
    {
        public $fileinputname$QueryValidator()
        {
            RuleFor(o => o).NotNull();
        }
    }
}