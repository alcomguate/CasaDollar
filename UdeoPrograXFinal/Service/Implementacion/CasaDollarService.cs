using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.UnitOfWork;

namespace UdeoPrograXFinal.Service
{
    public class CasaDollarService : ICasaDollarService
    {

        IUnitOfWork _unitOfWork;

        public CasaDollarService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public decimal GetCajaChica(List<Cliente> clientes)
        {
            decimal totalIngresos = 0;
            decimal porcentaje = new decimal(0.05);
            foreach(Cliente actual in clientes){
                totalIngresos += (actual.IngresoMensual * actual.PorcentajeAporte);
            }
            return totalIngresos * porcentaje;
            
        }

        public decimal GetGastos(List<Cliente> clientes)
        {
            decimal totalIngresos = 0;
            decimal porcentaje = new decimal(0.10);
            foreach (Cliente actual in clientes)
            {
                totalIngresos += (actual.IngresoMensual * actual.PorcentajeAporte);
            }
            return totalIngresos * porcentaje;

        }

        public decimal GetPublicidad(List<Cliente> clientes)
        {
            decimal totalIngresos = 0;
            decimal porcentaje = new decimal(0.85);
            foreach (Cliente actual in clientes)
            {
                totalIngresos += (actual.IngresoMensual * actual.PorcentajeAporte);
            }
            return totalIngresos * porcentaje;

        }
    }
}