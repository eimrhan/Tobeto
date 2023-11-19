using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult 
    // Interface, başka bir interface'i implemente edince içerisine tekrar implement edilmez.
    {
        T Data { get; }
    }
}
