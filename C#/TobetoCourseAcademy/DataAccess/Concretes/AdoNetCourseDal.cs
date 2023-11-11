using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetCourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine(course.Name + " Ado.Net kullanılarak veritabanına eklendi.");
        }
    }
}
