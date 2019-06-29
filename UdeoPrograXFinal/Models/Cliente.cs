﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdeoPrograXFinal.Models
{
    public class Cliente
    {

        private int id;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private DateTime nacimiento;

        public int Id { get => id; set => id = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }

    }
}