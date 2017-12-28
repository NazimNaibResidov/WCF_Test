using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace respostorypattern.Repsotory
{
   public interface IRepsotory<T> where T:class
    {
        List<T> Listle();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
