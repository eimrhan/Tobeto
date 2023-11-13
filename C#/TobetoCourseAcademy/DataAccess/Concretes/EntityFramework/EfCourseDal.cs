using DataAccess.Abstracts;
using Entites.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course entity)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var deletedEntity = db.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Set<Course>().SingleOrDefault(filter);
            }
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return filter == null ? db.Set<Course>().ToList() : db.Set<Course>().Where(filter).ToList();
            }
        }

        public void Update(Course entity)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var updatedEntity = db.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
