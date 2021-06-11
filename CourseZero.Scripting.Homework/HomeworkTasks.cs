using System;

namespace CourseZero.Scripting.Homework
{
    public static class HomeworkTasks
    {
        /// <summary>
        /// Вычисление остатка от деления одного числа на другое
        /// </summary>
        /// <remarks>
        /// НЕ использовать встроеннный оператор %
        /// </remarks>
        /// <param name="number">Делимое число</param>
        /// <param name="divider">Делитель</param>
        /// <returns>Остаток деления</returns>
        public static int Remainder(int number, int divider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вычисление среднего арифиметического массива чисел
        /// </summary>
        /// <remarks>
        /// Сумма всех чисел делёная на их количество
        /// </remarks>
        /// <param name="numbers">Массив чисел</param>
        /// <returns>Среднее арифметическое массива</returns>
        public static decimal Averange(decimal[] numbers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сортировка массива
        /// </summary>
        /// <remarks>
        /// Не создавать второй массив, 
        /// а проводить сортировку в исходном
        /// </remarks>
        /// <param name="numbers">Исходный массив чисел</param>
        /// <param name="isAccendant">Признак сортировки по возрастанию</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] Sort(int[] numbers, bool isAccendant)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Инвертировать строку, первый символ должен 
        /// стать последним, второй - предпоследним и т.д.
        /// </summary>
        /// <param name="inputString">Исходная строка</param>
        /// <returns>Инвертированная строка</returns>
        public static string Invert(string inputString)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Инвертировать регистр символов строки,
        /// большие буквы сделать маленькими и наоборот
        /// </summary>
        /// <param name="inputString">Входящая строка</param>
        /// <returns>Исходящая строка</returns>
        public static string InvertCase(string inputString)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вернуть массив являющийся пересечением двух других,
        /// в него должны войти числа имеющиеся в обоих массивах
        /// </summary>
        /// <param name="arr1">Первый массив для пересечения</param>
        /// <param name="arr2">Второй массив для пересечения</param>
        /// <returns>Итоговый массив</returns>
        public static int[] Intersect(int[] arr1, int[] arr2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Перевести строку содержащую римское число в целое число,
        /// ограничимся числами от 1 до 1000
        /// </summary>
        /// <param name="romanNumber">Строка с римским числом</param>
        /// <returns>Итоговое число</returns>
        public static int RomanToInteger(string romanNumber)
        {
            throw new NotImplementedException();
        }
    }
}
