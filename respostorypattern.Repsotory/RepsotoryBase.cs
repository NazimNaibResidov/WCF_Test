using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace respostorypattern.Repsotory
{
    using ORM;
    using respostorypattern.ORM.Models;

    public class RepsotoryBase<T> : IRepsotory<T> where T:class
    {
        private KuzeyYeliContext context;

        public KuzeyYeliContext Context
        {
            get {

                if (context == null)

                    context = new KuzeyYeliContext();
                return context; }
                set { context = value; }
        }

        public bool Add(T entity)
        {
            Context.Set<T>().Add(entity);
            try
            {
 
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            try
            {

              return  Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<T> Listle()
        {
            return Context.Set<T>().ToList();
        }

        public bool Update(T entity)
        {
            try
            {
               return Context.SaveChanges()>0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
