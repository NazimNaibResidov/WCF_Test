using respostorypattern.Repsotory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace respostorypattern.WCF
{ using respostorypattern.Exetansion;
    using System.ServiceModel;
    using respostorypattern.Repsotory;

    public class ServiceBase<Rep, Entity, DTO> : IService<DTO> where DTO : class
      where Entity : class
        where Rep : RepsotoryBase<Entity>
    {
        private Rep repsotory;

        public Rep Repsotry
        {
            get
            {

                repsotory = repsotory ?? Activator.CreateInstance<Rep>();

                return repsotory;
            }
            set { repsotory = value; }
        }

        public bool Ekele(DTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Guncelle(DTO entity)
        {
            throw new NotImplementedException();
        }

        public List<DTO> Listele()
        {

            return Repsotry.Listle().Select(x => x.MapTo<DTO>()).ToList();
        }

        public bool Sil(DTO entity)
        {
            throw new NotImplementedException();
        }
    }
}