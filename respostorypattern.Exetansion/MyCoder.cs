using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace respostorypattern.Exetansion
{
   public static class MyCoder
    {
        public static T MapTo<T>(this object soruce)
        {
            T entity = Activator.CreateInstance<T>();
         
          PropertyInfo [] kaynaproperty=  soruce.GetType().GetProperties();
          PropertyInfo [] hedeftip=   typeof(T).GetProperties();
            foreach (PropertyInfo item in kaynaproperty)
            {
                if (item!=null)
                {
                    PropertyInfo hp = hedeftip.FirstOrDefault(x =>  x.Name.ToUpper() == item.Name.ToUpper());
                    var value= item.GetValue(soruce);
                    hp.SetValue(entity, value);
                       
                        
                }
            }
            return entity;
        }
    }
}
