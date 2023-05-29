using CoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
    public class GenericRepository <T> where T : class,new()
    {
        Context c = new Context();
        public List<T> Tlist()
        {
           return c.Set<T>().ToList();
        }
        public void TDelete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }

        public void TAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public void TUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
        public T TGet(int p)
        {
            return c.Set<T>().Find(p);
        }




    }
}
