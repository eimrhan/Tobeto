using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // çift parametre gönderildiği durumlarda bu constructor çalışır,
        // ve bu metodun aldığı isSuccess parametresini tek parametreli olana gönderir.
        // kod tekrarına düşmemek için "IsSuccess = isSuccess;" kodunu buradan kaldırdık.
        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            Message = message;
            // getterlar read only'dir, ama sadece constructor dışında.
            // constructor içerisinde set ediyoruz.
        }

        // tek parametre gönderilirse bu çalışır.
        public Result (bool isSuccess) // constructor overloading
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; }
        public string Message { get; }
    }
}
