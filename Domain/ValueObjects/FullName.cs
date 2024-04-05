using Domain.Validations;
using Domain.Validations.Validators;

namespace Domain.ValueObjects
{
    /// <summary>
    /// Представляет полное имя человека.
    /// </summary>
    public class FullName : BaseValueObject
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса FullName с указанием имени, фамилии и отчества.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="middleName">Отчество (необязательно).</param>
        public FullName(string firstName, string lastName, string? middleName)
        {
            FirstName = new FullNameValidator(nameof(firstName)).ValidateWithErrors(firstName);
            LastName = new FullNameValidator(nameof(lastName)).ValidateWithErrors(lastName);

            if (middleName is not null)
            {
                MiddleName = new FullNameValidator(nameof(middleName)).ValidateWithErrors(middleName);
            }
        }

        /// <summary>
        /// Получает или задает имя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Получает или задает фамилию.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Получает или задает отчество.
        /// </summary>
        public string? MiddleName { get; set; }
    }
}