using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Proyect.Models
{
    public class Repartidor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DPI { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}