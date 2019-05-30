using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.Models
{
    public class Finca
    {
        public int FincaId { get; set; }

        public string nombre { get; set; }

        public string vereda { get; set; }

        public string municipio { get; set; }

        public string departamento { get; set; }

    }
}