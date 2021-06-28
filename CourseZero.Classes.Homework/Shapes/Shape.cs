using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.Homework.Shapes
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    public abstract class Shape
    {

        /// <summary>
        /// Рассчет площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract decimal Area();

        /// <summary>
        /// Расчёт периметра фигуры
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        public abstract decimal Perimeter();
    }
}
