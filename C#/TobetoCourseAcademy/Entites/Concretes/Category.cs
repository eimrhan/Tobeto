﻿using Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Course> Courses { get; set; }
    }
}
