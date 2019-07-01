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
            var resultData = await _clienteService.GetClienteById(id);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData.FirstOrDefault());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/cliente")]
        public IHttpActionResult addCliente(Cliente dt)
        {
            var resultData = _clienteService.Insert(dt);
            return Ok(resultData);
        }

    }
}
