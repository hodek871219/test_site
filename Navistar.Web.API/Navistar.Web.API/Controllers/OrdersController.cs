using Navistar.Business.Orders;
using Navistar.Model.common;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Navistar.Utils.Logger;
using log4net;

namespace Navistar.Web.API.Controllers
{
    //    [EnableCors("MyPolicy")]
    [Produces("application/json")]
    [Route("api/Orders")]
    //[RequireHttps]
    //[Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrderBusiness<TCP001_PEDIDO> _efBusinessInstance;
        private readonly IOrderBusinessEF  _efBusinessEFInstance;

        private TelemetryClient telemetryClient;
        private ILog _log;
      

        public OrdersController(IOrderBusiness<TCP001_PEDIDO> efBusinessInstance, IOrderBusinessEF efBusinessInstanceEF)
        {
            _efBusinessInstance = efBusinessInstance;
            _efBusinessEFInstance = efBusinessInstanceEF;
            telemetryClient = new TelemetryClient();
            _log = new Navistar.Utils.Logger.Logger().GetLog();
            
        }
        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var response = await _efBusinessInstance.GetOrders();
                _log.Info("Obtener Ordenes" + response.ToString());
                telemetryClient.TrackEvent("Obtener Ordenes", new Dictionary<string, string>()
                { ["Environment"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") });
                return Ok(response);
               
            }
            catch (Exception exception)
            {
                var message = exception.Message;
                //evento para exepciones
                telemetryClient.TrackException(exception, new Dictionary<string, string>()
                { ["Environment"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") });
                return BadRequest(message);
            }
        }

        [HttpGet]
        [Route("GetTopTenOrders")]
        public async Task<IActionResult> GetTopTenOrders()
        {
            try
            {
                var response = await _efBusinessEFInstance.GetTopTenOrders();
                _log.Info("Obtener Ordenes" + response.ToString());
                telemetryClient.TrackEvent("Obtener Ordenes", new Dictionary<string, string>()
                { ["Environment"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") });
                return Ok(response);

            }
            catch (Exception exception)
            {
                var message = exception.Message;
                //evento para exepciones
                telemetryClient.TrackException(exception, new Dictionary<string, string>()
                { ["Environment"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") });
                return BadRequest(message);
            }
        }




    }
}
