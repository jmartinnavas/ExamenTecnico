using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.Models
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string contacto { get; set; }

        public string departamento { get; set; }
    }
}