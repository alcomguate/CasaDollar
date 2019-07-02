using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CasaDollarWeb.Controllers
{
    public class GastosController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            
            Dictionary<string, decimal> model = new Dictionary<string, decimal>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56746/api/casadollar/");

                var responseTask = client.GetAsync("totalgastos");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Dictionary<string, decimal>>();
                    readTask.Wait();
                    
                    model = readTask.Result;
                }
                else
                {
                    model = new Dictionary<string, decimal>();
                    ModelState.AddModelError(string.Empty, "Error en solicitud");
                }
            }
            return View(model);
        }
    }
}