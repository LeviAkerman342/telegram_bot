using FluentValidation;
using System;

namespace Domain.Validations.Validators
{
    /// <summary>
    /// Валидатор для проверки формата номера телефона.
    /// </summary>
    public class PhoneValidator : AbstractValidator<string>
    {
        /// <summary>
        /// Создает экземпляр валидатора для номера телефона.
        /// </summary>
        /// <param name="paramName">Имя параметра.</param>
        public PhoneValidator(string paramName)
        {
            RuleFor(phone => phone)
                .NotNull().WithMessage($"Номер телефона ({paramName}) не должен быть пустым.")
                .NotEmpty().WithMessage($"Номер телефона ({paramName}) не должен быть пустым.")
                .Matches(RegexPatterns.Phone).WithMessage($"Неверный формат номера телефона ({paramName}).");
        }
    }
}