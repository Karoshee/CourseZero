using System;

namespace CourseZero.Exceptions
{
    class Program
    {
        static void OldMain(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            try
            {
                //throw new CustomException("Message 1");
                int i = int.Parse(input);
                Console.WriteLine();
                Console.WriteLine("Вы ввели число: " + i);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Вы ввели неверное значение");
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            Result<int> result = RemoteMethod(input);
            Console.WriteLine();
            if (result.IsSuccess)
            { 
                Console.WriteLine("Вы ввели число: " + result.Value); 
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static Result<int> RemoteMethod(string input)
        {
            try
            {
                int i = int.Parse(input);
                //return new Result<int> { IsSuccess = true, Value = i };
                return Result.Done(i);
            }
            catch (Exception ex)
            {
                //return new Result<int> { Exception = ex, Message = "Случилось что-то не то" };
                return Result.Fail<int>("Случилось что-то не то", ex);
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("Случилась ошибка");
        }
    }
}
