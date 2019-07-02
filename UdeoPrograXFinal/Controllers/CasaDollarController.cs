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
    public class CasaDollarController : ApiController
    {

        ICasaDollarService _casaDollarService;
        IClienteService _clienteService;

        public CasaDollarController() { }

        public CasaDollarController(ICasaDollarService casaDollarService, IClienteService clienteService)
        {
            _casaDollarService = casaDollarService;
            _clienteService = clienteService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/casadollar/totalgastos")]
        public async Task<IHttpActionResult> GetCalculosMensuales()
        {
            var allClientes = await _clienteService.GetAllCliente();
            List<Cliente> clientes = allClientes.ToList(); 
            decimal gastos = _casaDollarService.GetGastos(clientes);
            decimal publicidad = _casaDollarService.GetPublicidad(clientes);
            decimal cajaChica = _casaDollarService.GetCajaChica(clientes);

            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            result.Add("Gastos", gastos);
            result.Add("Publicidad", publicidad);
            result.Add("CajaChica", cajaChica);
            return Ok(result);
        }


    }
}
