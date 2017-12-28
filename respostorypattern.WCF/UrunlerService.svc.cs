using respostorypattern.DTO.Urunler;
using respostorypattern.ORM.Models;
using respostorypattern.Repsotory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace respostorypattern.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UrunlerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UrunlerService.svc or UrunlerService.svc.cs at the Solution Explorer and start debugging.
   
    public class UrunlerService : ServiceBase<UrunRepsotory,Urunler,UrunDTO>
    {
       
    }
}
