using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Reflection.Homework
{
    /// <summary>
    /// Универсальный класс сравнения двух любых объектов
    /// по значениям всех свойств
    /// </summary>
    /// <typeparam name="T">Тип сравниваемых объектов</typeparam>
    public class UniversalEqualityComparer<T> : IEqualityComparer<T>
    {
        /// <summary>
        /// Сравнить два объекта по всем свойствам
        /// </summary>
        /// <param name="x">Первый объект для сравнения</param>
        /// <param name="y">Второй объект для сравнения</param>
        /// <returns>True - если свойства этих объектов равны,
        /// иначе false</returns>
        public bool Equals(T? x, T? y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получить хеш-код объектов
        /// </summary>
        /// <param name="obj">Объект, чей хеш-код высчитываем</param>
        /// <returns>Хеш-код объекта</returns>
        public int GetHashCode([DisallowNull] T obj)
        {
            return obj.GetHashCode();
        }
    }
}
