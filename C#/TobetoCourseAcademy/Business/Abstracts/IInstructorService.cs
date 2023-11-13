using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    internal interface IInstructorService
    {
        List<Instructor> GetInstructors();
    }
}
