using System;

namespace Domain.Entities
{
    /// <summary>
    /// Базовый абстрактный класс сущности.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор сущности.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Переопределение метода Equals для сравнения с другим объектом.
        /// </summary>
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            BaseEntity other = (BaseEntity)obj;
            return Id.Equals(other.Id);
        }

        /// <summary>
        /// Переопределение метода GetHashCode для получения хэш-кода объекта.
        /// </summary>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}