//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prueba
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finca
    {
        public Finca()
        {
            this.Propietario = new HashSet<Propietario>();
            this.Residentes = new HashSet<Residentes>();
        }
    
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string vereda { get; set; }
        public string municipio { get; set; }
        public string departamento { get; set; }
    
        public virtual ICollection<Propietario> Propietario { get; set; }
        public virtual ICollection<Residentes> Residentes { get; set; }
    }
}
