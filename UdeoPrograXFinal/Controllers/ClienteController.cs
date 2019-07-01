using Exceptionless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.Controllers
{

    [AllowAnonymous]
    public class ClienteController : ApiController
    {

        IClienteService _clienteService;

        public ClienteController() { }

        public ClienteController(IClienteService clienteService) {
            _clienteService = clienteService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/cliente/Findall")]
        public async Task<IHttpActionResult> GetAllClientes()
        {
            var resultData = await _clienteService.GetAllCliente();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/cliente/{id}")]
        public async Task<IHttpActionResult> GetClienteById(int id)
        {
            new Exception("Busqueda de datos del cliente:" + id).ToExceptionless().Submit();
            ExceptionlessClient.Default.SubmitLog("Busqueda de datos del cliente: " + id,
                    Exceptionless.Logging.LogLevel.Info);
            ExceptionlessClient.Default.CreateLog("", Exceptionless.Logging.LogLevel.Debug);
            var resultData = await _clienteService.GetClienteById(id);
            if (resultData == null)
            {
                
                ExceptionlessClient.Default.SubmitLog("Error en busqueda de cliente " + id, 
                    Exceptionless.Logging.LogLevel.Error);
                return NotFound();
            }
            ExceptionlessClient.Default.SubmitLog("Resultado: " + resultData,
                    Exceptionless.Logging.LogLevel.Info);
            return Ok(resultData.FirstOrDefault());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/cliente")]
        public IHttpActionResult addCliente(Cliente dt)
        {
            ExceptionlessClient.Default.SubmitLog("Agregando cliente", Exceptionless.Logging.LogLevel.Info);
            var resultData = _clienteService.Insert(dt);
            return Ok(resultData);
        }

    }
}
