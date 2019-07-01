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
    public class PaisController : ApiController
    {

        IPaisService _paisService;
        IContinenteService _continenteService;

        public PaisController()
        {
        }

        public PaisController(IPaisService paisService, IContinenteService continenteService)
        {
            _paisService = paisService;
            _continenteService = continenteService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/pais")]
        public async Task<IHttpActionResult> GetPaises()
        {
            var resultData = await _paisService.GetAllPaises();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/continente/{continenteid}/pais")]
        public async Task<IHttpActionResult> GetPaisesByContinente(int continenteid)
        {
            dynamic continente = await _continenteService.GetContinenteById(continenteid);
            var resultData = await _paisService.GetPaisesByContinente(continente);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}
