using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.Homework.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона Б</param>
        /// <param name="c">Сторона С</param>
        public Triangle(decimal a, decimal b, decimal c)
        {

        }

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона Б</param>
        /// <param name="alfa">Угол между А и Б</param>
        public Triangle(decimal a, decimal b, double alfa)
        {

        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
