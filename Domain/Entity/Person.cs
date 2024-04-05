using Domain.Validations;
using Domain.Validations.Validators;
using Domain.ValueObjects;


namespace Domain.Entities
{
    public class Person : BaseEntity
    {
       
        /// <summary>
        /// Full name
        /// </summary>
        public FullName FullName { get; set; }

        /// <summary>
        /// Date birsday
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        public int Age => DateTime.Now.Year - BirthDay.Year;

        /// <summary>
        /// Number phone
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// TG name
        /// </summary>
        public string Telegram { get; set; }
        
        
        /// <summary>
        /// Конструктор c валидацией
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="gender"></param>
        /// <param name="birthDay"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="telegram"></param>
        public Person(FullName fullName, Gender gender, DateTime birthDay, string phoneNumber, string telegram)
        {
            Gender = new EnumValidator<Gender>(nameof(gender), [Gender.Other]).ValidateWithErrors(gender);
            BirthDay = new BirthDateValidator(nameof(birthDay)).ValidateWithErrors(birthDay);
            PhoneNumber = new PhoneValidator(nameof(phoneNumber)).ValidateWithErrors(phoneNumber);
            Telegram = new TelegramNameValidator(nameof(telegram)).ValidateWithErrors(telegram);
        }

    }
}