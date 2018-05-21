using FinalProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        protected FinalProjectDbContext Context;

        //DBSet
        protected DbSet<T> DBSet
        {
            get
            {
                return Context.Set<T>();
            }
        }
        //Constructor
        public BaseRepository() => Context = new FinalProjectDbContext();
        //GetAll
        public List<T> GetAll() => Context.Set<T>().ToList();
        //GetByID
        public T GetByID(int id) => Context.Set<T>().Find(id);
        //Create
        public void Create(T item)
        {
            Context.Set<T>().Add(item);
            Context.SaveChanges();
        }
        //Update
        public void Update(T item, Func<T, bool> findByIDPredecate)
        {
            var local = Context.Set<T>()
                         .Local
                         .FirstOrDefault(findByIDPredecate);// (f => f.ID == item.ID);
            if (local != null)
            {
                Context.Entry(local).State = EntityState.Detached;
            }

            Context.Entry(item).State = EntityState.Modified;

            Context.SaveChanges();
        }
        //Save
        public void Save(T item)
        {
            if (item.Id == 0)
            {
                Create(item);
                return;
            }
            Update(item, x => x.Id == item.Id);
        }
        //DeleteByID
        public bool DeleteByID(int id)
        {
            bool isDeleted = false;
            T dbItem = Context.Set<T>().Find(id);
            if (dbItem != null)
            {
                Context.Set<T>().Remove(dbItem);
                int recordsChanged = Context.SaveChanges();
                isDeleted = recordsChanged > 0;
            }
            return isDeleted;
        }
    }
}
