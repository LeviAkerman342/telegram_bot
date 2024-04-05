using FluentValidation;
using System;

namespace Domain.Validations.Validators
{
    /// <summary>
    /// Валидатор для проверки даты рождения.
    /// </summary>
    public class BirthDateValidator : AbstractValidator<DateTime>
    {
        /// <summary>
        /// Создает экземпляр валидатора даты рождения.
        /// </summary>
        /// <param name="paramName">Имя параметра.</param>
        public BirthDateValidator(string paramName)
        {
            RuleFor(date => date)
                .NotNull().WithMessage($"Дата рождения ({paramName}) не должна быть пустой.")
                .NotEmpty().WithMessage($"Дата рождения ({paramName}) не должна быть пустой.")
                .LessThan(DateTime.Now.AddDays(1)).WithMessage($"Дата рождения ({paramName}) не может быть в будущем.")
                .GreaterThan(DateTime.Now.AddYears(-150)).WithMessage($"Дата рождения ({paramName}) слишком старая.");
        }
    }
}