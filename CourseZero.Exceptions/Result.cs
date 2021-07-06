using System;

namespace CourseZero.Exceptions
{
    public class Result
    {
        public bool IsSuccess { get; set; }

        public Exception Exception { get; set; }

        public string Message { get; set; }

        public static Result Done()
            => new Result { IsSuccess = true };

        public static Result<T> Done<T>(T value)
            => new Result<T> { IsSuccess = true, Value = value };

        public static Result Fail(string message = "", Exception exception = null)
            => new Result { Message = message, Exception = exception };

        public static Result<T> Fail<T>(string message = "", Exception exception = null)
            => new Result<T> { Message = message, Exception = exception };
    }

    public class Result<T> : Result
    {
        public T Value { get; set; }
    }

}
