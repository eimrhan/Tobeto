using Core.Utilities.Result;
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
        IDataResult<List<Instructor>> GetInstructors();
        IDataResult<Instructor> GetInstructorById(int id);
        IResult Add(Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);
    }
}
