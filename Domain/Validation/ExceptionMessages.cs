namespace Domain.Validations
{
    /// <summary>
    /// Содержит шаблоны сообщений об ошибках для валидации.
    /// </summary>
    public abstract class ValidationMessages
    {
        /// <summary>
        /// Сообщение об ошибке, когда значение равно null.
        /// </summary>
        public const string NullError = "{0} должно быть заполнено";

        /// <summary>
        /// Сообщение об ошибке, когда значение пустое.
        /// </summary>
        public const string EmptyError = "{0} не должно быть пустым";

        /// <summary>
        /// Сообщение об ошибке, когда дата слишком старая.
        /// </summary>
        public const string OldDateError = "{0} слишком старое";

        /// <summary>
        /// Сообщение об ошибке, когда дата в будущем.
        /// </summary>
        public const string FutureDateError = "{0} не может быть в будущем";

        /// <summary>
        /// Сообщение об ошибке, когда неверный формат ника в Telegram.
        /// </summary>
        public const string InvalidTelegramNameFormat = "{0} имеет неверный формат ника в Telegram";

        /// <summary>
        /// Сообщение об ошибке, когда неверный формат номера телефона.
        /// </summary>
        public const string InvalidPhoneFormat = "{0} имеет неверный формат номера телефона";

        /// <summary>
        /// Сообщение об ошибке, когда неверный формат имени.
        /// </summary>
        public const string InvalidNameFormat = "{0} имеет неверный формат имени";

        /// <summary>
        /// Сообщение об ошибке, когда перечисление имеет значение по умолчанию.
        /// </summary>
        public const string DefaultEnum = "{0} не может быть значением по умолчанию в перечислении";
    }
}