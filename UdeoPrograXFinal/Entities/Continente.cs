using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdeoPrograXFinal.Entities
{
    public class Continente
    {

        private int id;
        private string nombre;
        private bool activo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Activo { get => activo; set => activo = value; }

    }
}