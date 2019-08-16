using Oil.Models;
using Oil.ViewModel.inUniForm;
using Oil.ViewModel.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oil.Repository.BLL
{
    public interface IOilBLO
    {
        IEnumerable<OilManger> GetMasterProc();
        void CreateProc(inOilManger input);

        void DeleteProc(Guid ID);

        void UpdateProc(inOilManger inUniResult);

        void Createoil();

        IEnumerable<OilDetail> GetOil();

        List<outcar> GetNum();

        List<outoil> GetOilName();
    }
}
