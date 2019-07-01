using CasaDollarWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CasaDollarWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Clientes()
        {
            IEnumerable<Cliente> members = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56746/api/cliente/");
                
                var responseTask = client.GetAsync("findall");
                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result;

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Cliente>>();
                    readTask.Wait();

                    members = readTask.Result;
                }
                else
                {
                    //Error response received   
                    members = Enumerable.Empty<Cliente>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            return View(members);
        }
    }
}