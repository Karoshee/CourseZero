using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.Homework.Operators
{
    /// <summary>
    /// Комплексное число
    /// </summary>
    public class ComplexNumber : IEquatable<ComplexNumber>
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="real">Действительная часть комплексного числа</param>
        /// <param name="notReal">Мнимая часть комплексного числа</param>
        public ComplexNumber(decimal real, decimal notReal)
        {

        }

        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber operator /(ComplexNumber number1, ComplexNumber number2)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ComplexNumber(int i)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ComplexNumber(double i)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ComplexNumber(decimal i)
        {
            throw new NotImplementedException();
        }

        public static explicit operator decimal(ComplexNumber i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Создание хеш-кода комплексного числа
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Сравнение с другим комплексным числом
        /// </summary>
        public bool Equals(ComplexNumber other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сравнение с другим объектом
        /// </summary>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Строковое представление комплексного числа
        /// </summary>
        /// <remarks>
        /// Варианты представления:
        /// 2,1 + 2,2i
        /// 2 + i
        /// 2
        /// 2i
        /// i
        /// </remarks>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
