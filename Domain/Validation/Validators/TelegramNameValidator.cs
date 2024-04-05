using FluentValidation;

namespace Domain.Validations.Validators
{
    /// <summary>
    /// Валидатор для проверки формата ника в Telegram.
    /// </summary>
    public class TelegramNameValidator : AbstractValidator<string>
    {
        /// <summary>
        /// Создает экземпляр валидатора для ника в Telegram.
        /// </summary>
        /// <param name="paramName">Имя параметра.</param>
        public TelegramNameValidator(string paramName)
        {
            RuleFor(telegram => telegram)
                .NotNull().WithMessage($"Ник в Telegram ({paramName}) не должен быть пустым.")
                .NotEmpty().WithMessage($"Ник в Telegram ({paramName}) не должен быть пустым.")
                .Matches(RegexPatterns.TelegramName).WithMessage($"Неверный формат ника в Telegram ({paramName}).");
        }
    }
}