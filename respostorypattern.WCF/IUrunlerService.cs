using respostorypattern.DTO.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace respostorypattern.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUrunlerService" in both code and config file together.
  
    public interface IUrunlerService:IService<UrunDTO>
    {
       
    }
}
