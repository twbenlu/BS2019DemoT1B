using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oil.Models.BLL;
using Oil.Repository.BLL;
using Oil.ViewModel.inUniForm;
using Oil.ViewModel.UniForm;

namespace Oil.WebApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OilController : Controller
    {
        private IOilBLO ioilBLO;
        public OilController(IOilBLO _iTestBLO)
        {
            ioilBLO = _iTestBLO;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public outUniResult Getnum()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = 200; 
                _outUniResult.Result = ioilBLO.GetNum();
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {

                throw new Exception();
            }

        }
        [HttpGet]
        public outUniResult GetOiLname()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = 200;
                _outUniResult.Result = ioilBLO.GetOilName();
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {


                throw new Exception();
            }

        }
        [HttpGet]
        public outUniResult GetOiL()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = 200; 
                _outUniResult.Result = ioilBLO.GetMasterProc();
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {


                throw new Exception();
            }

        }
        [HttpPost]
        public outUniResult CreateOiL(inOilManger input)
        {

            outUniResult _outUniResult = new outUniResult();
            try
            {
                _outUniResult.StatusCode = 200;
                ioilBLO.CreateProc(input);

                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {

                throw new Exception();
            }


        }
        [HttpPost]
        public outUniResult DeleteOil(inOilManger inUniResult)
        {
            outUniResult _outUniResult = new outUniResult();
            try
            {
                _outUniResult.StatusCode = 200;
                ioilBLO.DeleteProc(inUniResult.Id);
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {

                throw new Exception();
            }
        }
        [HttpPut]
        public outUniResult UpdateOil(inOilManger inUniResult)
        {
            outUniResult _outUniResult = new outUniResult();
            try
            {

                _outUniResult.StatusCode = 200;
                ioilBLO.UpdateProc(inUniResult);
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {

                throw new Exception();
            }


        }
        [HttpPost]
        public outUniResult CreateOilDetail()
        {

            outUniResult _outUniResult = new outUniResult();
            try
            {
                _outUniResult.StatusCode = 200;
                ioilBLO.Createoil();

                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {

                throw new Exception();
            }


        }
        [HttpGet]
        public outUniResult GetOilDetail()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = 200; 
                _outUniResult.Result = ioilBLO.GetOil();
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {


                throw new Exception();
            }

        }
    }
}