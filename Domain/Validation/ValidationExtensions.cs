using FluentValidation;

namespace Domain.Validations
{
    /// <summary>
    /// Расширение для валидации объектов с использованием FluentValidation.
    /// </summary>
    public static class ValidationExtensions
    {
        /// <summary>
        /// Проводит валидацию объекта с помощью заданного валидатора и выбрасывает исключение ValidationException в случае ошибок.
        /// </summary>
        /// <typeparam name="T">Тип объекта для валидации.</typeparam>
        /// <param name="validator">Валидатор объекта.</param>
        /// <param name="value">Объект для валидации.</param>
        /// <returns>Валидный объект.</returns>
        public static T ValidateWithErrors<T>(this IValidator<T> validator, T value)
        {
            var validationResult = validator.Validate(value);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return value;
        }
    }
}