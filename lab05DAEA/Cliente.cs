﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05DAEA
{
    public class Cliente
    {
        public required string idCliente { get; set; } 
        public required string NombreCompañia { get; set; }
        public string NombreContacto { get; set; }
        public string Direccion { get; set; }
        public string Region {  get; set; }
        public string CodPostal { get; set; }
        public string Pais {  get; set; }
        public string Telefono { get; set;}
        public string Fax { get; set; }
        public bool Estado { get; set;}
    }
}
