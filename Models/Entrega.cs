using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Proyect.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RepartidorId { get; set; }
        [ForeignKey("RepartidorId")]
        public Repartidor Repartidor { get; set; }

        [Display(Name = "Dirección origen")]
        public string DireccionOrigen { get; set; }
        [Display(Name = "Dirección destino")]
        public string DireccionDestino { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public string Indicaciones { get; set; }
        [Display(Name = "Peso del paquete")]
        public string Peso { get; set; }
        [Display(Name = "Persona a entegar")]
        public string NombreDestino { get; set; }
        [Display(Name = "DPI Persona")]
        public string DpiDestino { get; set; }
        [Display(Name = "Precio por paquete")]
        public decimal PrecioPaquete { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}