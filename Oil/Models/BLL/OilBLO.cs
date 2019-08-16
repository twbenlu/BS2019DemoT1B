using Newtonsoft.Json;
using Oil.Factory;
using Oil.Repository.BLL;
using Oil.Repository.DAL;
using Oil.ViewModel.inUniForm;
using Oil.ViewModel.UniForm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Oil.Models.BLL
{
    [DependencyRegister]
    public class OilBLO:IOilBLO
    {
        private IOilDAO ioilDAO;

        public OilBLO(IOilDAO _iOilDAO)
        {

            ioilDAO = _iOilDAO;
        }
        public List<outoil> GetOilName()
        {
            try
            {

                IEnumerable<OilDetail> Test = ioilDAO.Get_Oilname();
                List<outoil> result = new List<outoil>();
                foreach (var i in Test)
                {
                    outoil car = new outoil()
                    {
                       OilId=i.OilId,
                       Oilname=i.Oilname
                    };
                    result.Add(car);
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public List<outcar> GetNum()
        {
            try
            {

                IEnumerable<DeliveryCar> Test = ioilDAO.Get_Num();
                List<outcar> result = new List<outcar>();
                foreach(var i in Test)
                {
                    outcar car = new outcar()
                    {
                        CarNumber = i.CarNumber,
                        DeliveryCarId = i.DeliveryCarId
                    };
                    result.Add(car);
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public IEnumerable<OilManger> GetMasterProc()
        {
            try
            {

                IEnumerable<OilManger> Test = ioilDAO.Get_Value();
                return Test;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void CreateProc(inOilManger input)
        {
            try
            {
                var oilID = ioilDAO.Get_Oilname().FirstOrDefault(x => x.Oilname == input.OilName);
                var carID = ioilDAO.Get_Num().FirstOrDefault(x => x.CarNumber == input.CarNumber);
                Guid g= Guid.NewGuid();                
                DateTime saveUtcNow = DateTime.UtcNow;
                OilManger entity = new OilManger()
                {

                    Id = g,
                    Date = DateTime.UtcNow,
                    Oilname = input.OilName,
                    CarNumber = input.CarNumber,
                    Card = input.Card,
                    Mileage = input.Mileage,
                    OilMoney = input.OilMoney,
                    OilQuantity = input.OilQuantity,
                    OilId = oilID.OilId,
                    CarId=carID.DeliveryCarId
                    
                    
                };

                ioilDAO.Create_Value(entity);



            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void DeleteProc(Guid ID)
        {
            try
            {

                ioilDAO.Delete_Value(ID);

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void UpdateProc(inOilManger inUniResult)
        {
            try
            {
                var oilID = ioilDAO.Get_Oilname().FirstOrDefault(x => x.Oilname == inUniResult.OilName);
                var carID = ioilDAO.Get_Num().FirstOrDefault(x => x.CarNumber == inUniResult.CarNumber);

                DateTime saveUtcNow = DateTime.UtcNow;
                OilManger entity = new OilManger()
                {


                    Id = inUniResult.Id,
                    Date = DateTime.UtcNow,
                    Oilname = inUniResult.OilName,
                    CarNumber = inUniResult.CarNumber,
                    Card = inUniResult.Card,
                    Mileage = inUniResult.Mileage,
                    OilMoney = inUniResult.OilMoney,
                    OilQuantity = inUniResult.OilQuantity,
                    OilId = oilID.OilId,
                    CarId = carID.DeliveryCarId
                };
                ioilDAO.Update_Value(entity);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public IEnumerable<OilDetail> GetOil()
        {
            try
            {

                IEnumerable<OilDetail> Test = ioilDAO.Get_Oil();
                return Test;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Createoil()
        {
            try
            {
                HttpWebRequest request = (WebRequest.Create(@"https://quality.data.gov.tw/dq_download_json.php?nid=6339&md5_url=a03335ba6b0bead4ec405a69605db65c")) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //string root = Encoding.UTF8.GetString(request.ToString());
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string RtvStr = sr.ReadToEnd();
                byte[] encodeBytes = Encoding.UTF8.GetBytes(RtvStr);
                byte[] bConvert = System.Text.UnicodeEncoding.Convert(System.Text.Encoding.UTF8, System.Text.Encoding.Unicode, encodeBytes);
                string sText = System.Text.Encoding.Unicode.GetString(bConvert);
                //string root = Encoding.UTF8.GetString(RtvStr.ToArray());
                List<oilinResult> roots = JsonConvert.DeserializeObject<List<oilinResult>>(sText);
                List<OilDetail> root = new List<OilDetail>();
                foreach (var i in roots)
                {
                    root.Add(new OilDetail()
                    {

                        Category = i.型別名稱,
                        Oilnumber = i.產品編號,
                        Oilname = i.產品名稱,
                        Package = i.包裝,
                        Sellto = i.銷售對象,
                        Tradelocate = i.交貨地點,
                        Salesunit = i.計價單位,
                        ReferencePrice = i.參考牌價,
                        BusinessTax = i.營業稅,
                        GoodTax = i.貨物稅,
                        DateTimeOffset = i.牌價生效時間,
                        Remarks = i.備註,


                    });

                }
                foreach (OilDetail oil in root)
                {
                    Guid g;
                    g = Guid.NewGuid();

                    OilDetail oilDetail = new OilDetail()
                    {
                        OilId = g,
                        Category = oil.Category,
                        Oilname = oil.Oilname,
                        Oilnumber = oil.Oilnumber,
                        Package = oil.Package,
                        Sellto = oil.Sellto,
                        Salesunit = oil.Salesunit,
                        Remarks = oil.Remarks,
                        ReferencePrice = oil.ReferencePrice,
                        BusinessTax = oil.BusinessTax,
                        GoodTax = oil.GoodTax,
                        DateTimeOffset = oil.DateTimeOffset,
                        Tradelocate = oil.Tradelocate,
                        UpdataTime = DateTime.UtcNow

                    };
                    ioilDAO.Create_oil(oilDetail);
                }


            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
