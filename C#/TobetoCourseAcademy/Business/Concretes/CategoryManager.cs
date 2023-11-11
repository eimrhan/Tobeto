using DataAccess.Concretes;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager
    {
        public void Add(Category category)
        {
            // iş kurallarını işlet, geçerse devam eder ve:

            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Add(category);
        }

    }
}
