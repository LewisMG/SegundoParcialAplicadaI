using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SegundaParcial.Entidades
{
    public class Mantenimiento
    {
        public int MantenimientoId { get; set; }
        public DateTime FechaActual { get; set; }
        public string Vehiculo { get; set; }
        public string Taller { get; set; }
        public string Servicio { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Importe { get; set; }

        [ForeignKey("VehiculoId")]
        public virtual Vehiculos vehiculo { get; set; }

        public Mantenimiento()
        {

        }
    }
}
