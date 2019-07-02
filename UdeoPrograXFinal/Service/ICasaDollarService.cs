using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Service
{
    public interface ICasaDollarService
    {

        decimal GetGastos(List<Cliente> clientes);

        decimal GetPublicidad(List<Cliente> clientes);

        decimal GetCajaChica(List<Cliente> clientes);

    }
}
