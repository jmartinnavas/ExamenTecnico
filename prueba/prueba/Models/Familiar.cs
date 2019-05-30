using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.Models
{
    public class Familiar
    {
        public int FamiliarId { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string contacto { get; set; }

        public string parentesco { get; set; }

        public Boolean propietario { get; set; }

        public Finca fincaperteneciente { get; set; }
    }
}