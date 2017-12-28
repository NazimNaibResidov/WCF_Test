using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace respostorypattern.WCF
{
    [ServiceContract]
    public interface IService<DTO> where DTO : class
    {
        [OperationContract]
        List<DTO> Listele();
        [OperationContract]
        bool Ekele(DTO entity);
        [OperationContract]
        bool Sil(DTO entity);
        [OperationContract]
        bool Guncelle(DTO entity);
    }
}
