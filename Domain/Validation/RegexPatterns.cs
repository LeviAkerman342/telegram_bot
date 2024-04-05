using System.Text.RegularExpressions;

namespace Domain.Validations
{
    /// <summary>
    /// Содержит регулярные выражения для валидации различных форматов данных.
    /// </summary>
    public class RegexPatterns
    {
        /// <summary>
        /// Регулярное выражение для проверки формата номера телефона.
        /// </summary>
        public static readonly Regex Phone = new(@"\+373[4,9]\d{5}$");

        /// <summary>
        /// Регулярное выражение для проверки формата ника в Telegram.
        /// </summary>
        public static readonly Regex TelegramName = new(@"^@[A-Za-z0-9_]+$");

        /// <summary>
        /// Регулярное выражение для проверки формата полного имени.
        /// </summary>
        public static readonly Regex FullName = new(@"^[a-zA-Zа-яА-Я0-9']+$");
    }
}