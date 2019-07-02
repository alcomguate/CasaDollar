using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Net.Http;
using UdeoPrograXFinal.Service;
using UdeoPrograXFinal.Repository;
using UdeoPrograXFinal.Infrastructure;
using UdeoPrograXFinal.UnitOfWork;
using Newtonsoft.Json.Serialization;
using UdeoPrograXFinal.Resolver;
using Unity;
using Microsoft.Owin.Security.OAuth;
using Exceptionless;

namespace UdeoPrograXFinal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ExceptionlessClient.Default.RegisterWebApi(config);

            var container = new UnityContainer();

            container.RegisterType<IClienteRepository, ClienteRepository>();
            container.RegisterType<IContinenteRepository, ContinenteRepository>();
            container.RegisterType<IPaisRepository, PaisRepository>();
            container.RegisterType<IEstadoRepository, EstadoRepository>();
            
            container.RegisterType<IConnectionFactory, ConnectionFactory>();
            container.RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
            container.RegisterType<IClienteService, ClienteService>();
            container.RegisterType<IContinenteService, ContinenteService>();
            container.RegisterType<IPaisService, PaisService>();
            container.RegisterType<IEstadoService, EstadoService>();
            container.RegisterType<ICasaDollarService, CasaDollarService>();

            config.DependencyResolver = new UnityResolver(container);
            
            // Web API configuration and services
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
