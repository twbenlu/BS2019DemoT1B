using Oil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oil.Repository.DAL
{
    public interface IOilDAO
    {
        IEnumerable<OilManger> Get_Value();
        void Create_Value(OilManger test);

        void Delete_Value(Guid ID);

        void Update_Value(OilManger test);

        void Create_oil(OilDetail test);

        IEnumerable<OilDetail> Get_Oil();

        IEnumerable<DeliveryCar> Get_Num();

        IEnumerable<OilDetail> Get_Oilname();
    }
}
