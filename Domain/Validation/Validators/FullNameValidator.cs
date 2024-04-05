using FluentValidation;
using System.Text.RegularExpressions;

namespace Domain.Validations.Validators
{
    /// <summary>
    /// Валидатор для проверки полного имени.
    /// </summary>
    public class FullNameValidator : AbstractValidator<string>
    {
        /// <summary>
        /// Создает экземпляр валидатора для полного имени.
        /// </summary>
        /// <param name="paramName">Имя параметра.</param>
        public FullNameValidator(string paramName)
        {
            RuleFor(name => name)
                .NotNull().WithMessage($"Полное имя ({paramName}) не должно быть пустым.")
                .NotEmpty().WithMessage($"Полное имя ({paramName}) не должно быть пустым.")
                .Matches(RegexPatterns.FullName).WithMessage($"Неверный формат полного имени ({paramName}).");
        }
    }
}