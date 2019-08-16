using Oil.Factory;
using Oil.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oil.Models.DAL
{
    [DependencyRegister]
    public class OilDAO : IOilDAO
    {
        private readonly BS2019Context _context;

        public OilDAO(BS2019Context context)
        {
            _context = context;
        }
        public IEnumerable<OilDetail> Get_Oilname()
        {
            try
            {
                IEnumerable<OilDetail> Test = from x in _context.OilDetail
                                              select x;


                return Test;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public IEnumerable<DeliveryCar> Get_Num()
        {
            try
            {
                IEnumerable<DeliveryCar> Test = from x in _context.DeliveryCar
                                                select x;


                return Test;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public IEnumerable<OilManger> Get_Value()
        {
            try
            {
                IEnumerable<OilManger> Test = from x in _context.OilManger
                                               select x;


                return Test;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Create_Value(OilManger test)
        {
            try
            {
                _context.OilManger.Add(test);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Delete_Value(Guid ID)
        {
            try
            {
                _context.OilManger.Remove(_context.OilManger.Single(x => x.Id == ID));
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Update_Value(OilManger test)
        {
            try
            {
                var oriUser = _context.OilManger.Single(x => x.Id == test.Id);
                _context.Entry(oriUser).CurrentValues.SetValues(test);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Create_oil(OilDetail test)
        {
            try
            {
                _context.OilDetail.Add(test);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public IEnumerable<OilDetail> Get_Oil()
        {
            try
            {
                IEnumerable<OilDetail> Test = from x in _context.OilDetail
                                              select x;


                return Test;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
