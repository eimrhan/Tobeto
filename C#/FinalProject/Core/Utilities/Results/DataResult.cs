using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool isSuccess, string message) : base(isSuccess, message)
        {
            Data = data; // e burada niye kod tekrarı yaptık? diyorsan:
            // base dediğimiz alan Result'tur. Orada yapılan işlemleri burada tekrar yapmıyoruz.
            // this yapısını orada kullandığımız için burada tekrar yapıp aşağıya yönlendirmiyoruz.
            // base() parametreleri ile gerekli verileri Result(base)'a iletiyoruz.
        }
        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
