using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP2
{
    internal class Product // Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // Foreign Key
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        // CRUD - Create, Read, Update, Delete
    }
}
