using System;

namespace CourseZero.Scripting.Homework
{
    public static class HomeworkTasks
    {
        /// <summary>
        /// Форматирование значений:
        /// целое число должно иметь как минимум 4 цифры;
        /// дробное должно иметь как минимум 4 цифры после запятой;
        /// дата и время в формате 25.12.2020(22:35:41);
        /// значения между собой разделить пробелами
        /// </summary>
        /// <param name="number">Целое значение</param>
        /// <param name="flNumber">Дробное значение</param>
        /// <param name="dateTime">Дата и время</param>
        /// <returns>Вернуть форматированную строку</returns>
        public static string Format(int number, float flNumber, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Поиск максимального числа из четырёх
        /// </summary>
        /// <returns>Максимальное число</returns>
        public static int Max(int num1, int num2, int num3, int num4)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вычисление самого часто встречающегося символа
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Символ который встречается чаще всего</returns>
        public static char MostCommonChar(string input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удалить из строки все символы не яляющиеся числами
        /// </summary>
        /// <param name="input">Исходная строка</param>
        /// <returns>Строка состоящая из чисел</returns>
        public static string NumbersOnly(string input)
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
