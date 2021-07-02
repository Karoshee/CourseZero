using CourseZero.Classes.Homework.Shapes;
using System;

namespace CourseZero.Classes.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подсчитать и вывести на экран суммы периметров и площадей всех фигур из GetShapes()
        }

        public static Shape[] GetShapes()
        {
            return new Shape[]
            {
                new Triangle(3, 4, 5D),
                new Triangle(2, 3, 30D),
                new Circle(10),
                new Rectangle(4, 5),
                new Rectangle(2, 3),
                new Circle(2)
            };
        }
    }
}
