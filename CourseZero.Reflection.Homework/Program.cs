using System;
using System.Linq;

namespace CourseZero.Reflection.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleObject[] someCollection =
            {
                new SimpleObject(1, "text1", 2M),
                new SimpleObject(1, "text1", 3M),
                new SimpleObject(1, "text1", 3M),
                new SimpleObject(2, "text1", 2M),
                new SimpleObject(2, "text1", 2M),
                new SimpleObject(2, "text", 2M),
                new SimpleObject(2, "text", 2M),
                new SimpleObject(3, "text1", 2M),
                new SimpleObject(3, "text1", 2M),
                new SimpleObject(3, "text1", 3M),
            };

            // Здесь должны остаться только уникальные значения
            var onlyUniquesCollection = someCollection
                .Distinct(new UniversalEqualityComparer<SimpleObject>())
                .ToArray();
        }
    }

    public class SimpleObject
    {
        public int Index { get; set; }

        public string Text { get; set; }

        private decimal _Value { get; set; }

        public SimpleObject(int index, string text, decimal value)
        {
            Index = index;
            Text = text;
            _Value = value;
        }
    }
}
