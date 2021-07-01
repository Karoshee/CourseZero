using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseZero.Classes.Homework.Generics
{
    /// <summary>
    /// Отсортированная очередь элементов
    /// </summary>
    /// <typeparam name="T">
    /// Любой тип данных, который может сравнивать себя с себеподобными
    /// </typeparam>
    public class SortedQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="items">Элементы, которые нужно добавить в очередь</param>
        public SortedQueue(params T[] items)
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
            set
            {

            }
        }

        /// <summary>
        /// Добавить элемент в очередь
        /// </summary>
        /// <param name="item">Элемент для добавления в очередь</param>
        public void Add(T item)
        {

        }

        /// <summary>
        /// Удалить элемент из очереди
        /// </summary>
        /// <param name="index">Порядковый номер элемента</param>
        public void Delete(int index)
        {

        }

        /// <summary>
        /// Вернуть переборщик значений очереди
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сравнение очереди с другим объектов
        /// </summary>
        /// <param name="obj">Объект для сравнения</param>
        /// <returns>
        /// True - если объект это очередь и элементы равны друг другу, иначе false
        /// </returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Строковое представление очереди
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
