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
    public class EfInstructorDal : IInstructorDal
    {
        public void Add(Instructor entity)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(Instructor entity)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var deletedEntity = db.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Set<Instructor>().SingleOrDefault(filter);
            }
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return filter == null ? db.Set<Instructor>().ToList() : db.Set<Instructor>().Where(filter).ToList();
            }
        }

        public void Update(Instructor entity)
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
