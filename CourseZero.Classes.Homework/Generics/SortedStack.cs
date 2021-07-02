using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseZero.Classes.Homework.Generics
{
    /// <summary>
    /// Отсортированная стек элементов
    /// </summary>
    /// <typeparam name="T">
    /// Любой тип данных, который может сравнивать себя с себеподобными
    /// </typeparam>
    public class SortedStack<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="items">Элементы, которые нужно добавить в стек</param>
        public SortedStack(params T[] items)
        {

        }

        /// <summary>
        /// Индексер
        /// </summary>
        /// <param name="index">Порядковый номер элемента</param>
        public T this[int index]
        {
            get
            {
                return default(T);
            }
         }

        /// <summary>
        /// Добавить элемент в стек
        /// </summary>
        /// <param name="item">Элемент для добавления в стек</param>
        public void Add(T item)
        {

        }

        /// <summary>
        /// Удалить элемент из стека
        /// </summary>
        /// <param name="index">Порядковый номер элемента</param>
        public void Delete(int index)
        {

        }

        /// <summary>
        /// Вернуть переборщик значений стека
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вернуть переборщик значений стека
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вернуть порядковый номер элемента
        /// </summary>
        /// <param name="item">Элемент, порядковый номер которого ищем</param>
        /// <returns>Порядковый номер элемента</returns>
        public int IndexOf(T item)
        {
            return 0;
        }

        /// <summary>
        /// Посчитать хеш код всех элементов стека
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Сравнение стека с другим объектов
        /// </summary>
        /// <param name="obj">Объект для сравнения</param>
        /// <returns>
        /// True - если объект это стек и элементы равны друг другу, иначе false
        /// </returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Строковое представление стека
        /// </summary>
        /// <remarks>
        /// Вывести в таком виде = "[1, 2, 3, 5, 9]"
        /// </remarks>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
