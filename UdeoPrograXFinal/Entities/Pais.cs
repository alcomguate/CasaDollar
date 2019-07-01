using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdeoPrograXFinal.Entities
{
    public class Pais
    {

        private int id;
        private string nombre;
        private string nombreCorto;
        private int continente;
        private bool activo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreCorto { get => nombreCorto; set => nombreCorto = value; }
        public int Continente { get => continente; set => continente = value; }
        public bool Activo { get => activo; set => activo = value; }

    }
}