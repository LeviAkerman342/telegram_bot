using System;
using System.Text.Json;

namespace Domain.ValueObjects
{
    /// <summary>
    /// Базовый класс для значимых объектов.
    /// </summary>
    public abstract class BaseValueObject
    {
        /// <summary>
        /// Переопределение метода для сравнения двух объектов на идентичность.
        /// </summary>
        /// <param name="obj">Объект для сравнения.</param>
        /// <returns>True, если объекты идентичны, иначе - false.</returns>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            BaseValueObject other = (BaseValueObject)obj;
            return Serialize().Equals(other.Serialize());
        }

        /// <summary>
        /// Переопределение метода для вычисления хэш-кода объекта.
        /// </summary>
        /// <returns>Хэш-код объекта.</returns>
        public override int GetHashCode()
        {
            return Serialize().GetHashCode();
        }

        /// <summary>
        /// Метод для глубокого копирования объекта.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="source">Исходный объект.</param>
        /// <returns>Глубокая копия объекта.</returns>
        protected static T DeepClone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", nameof(source));
            }

            if (ReferenceEquals(source, null))
            {
                return default!;
            }

            using var memoryStream = new System.IO.MemoryStream();
            var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            serializer.Serialize(memoryStream, source);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            return (T)serializer.Deserialize(memoryStream);
        }

        /// <summary>
        /// Метод для сериализации объекта в JSON строку.
        /// </summary>
        /// <returns>JSON строка.</returns>
        private string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
