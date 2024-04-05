using FluentValidation;
using System;

namespace Domain.Validations.Validators
{
    /// <summary>
    /// Валидатор для проверки значения перечисления.
    /// </summary>
    /// <typeparam name="TEnum">Тип перечисления.</typeparam>
    public class EnumValidator<TEnum> : AbstractValidator<TEnum> where TEnum : Enum
    {
        /// <summary>
        /// Создает экземпляр валидатора для значения перечисления.
        /// </summary>
        /// <param name="paramName">Имя параметра.</param>
        /// <param name="defaultValues">Значения, которые не должны приниматься.</param>
        public EnumValidator(string paramName, params TEnum[] defaultValues)
        {
            foreach (var value in defaultValues)
            {
                RuleFor(enumValue => enumValue)
                    .NotEqual(value).WithMessage($"Значение параметра {paramName} не может быть значением по умолчанию.");
            }
        }
    }
}