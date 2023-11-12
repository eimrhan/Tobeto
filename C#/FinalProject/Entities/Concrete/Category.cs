using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // "Çıplak Class Kalmasın!"
    // IEntity ile işaretleme yaptık, Category'nin bir veritabanı tablosu olduğunu gösterdik.
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
