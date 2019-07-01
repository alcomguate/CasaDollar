using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.Controllers
{

    [AllowAnonymous]
    public class ContinenteController : ApiController
    {

        IContinenteService _continenteService;

        public ContinenteController() { }

        public ContinenteController(IContinenteService continenteService) {
            _continenteService = continenteService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/continente")]
        public async Task<IHttpActionResult> GetContinentes()
        {
            var resultData = await _continenteService.GetAllContinente();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }

    }
}
