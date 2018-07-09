using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class Mantenimiento
    {
        [Key]
        public int MantenimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public int VehiculoId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal itbis { get; set; }
        public decimal Total { get; set; }

        public virtual ICollection<MantenimientoDetalle> Detalle { get; set; }

        public Mantenimiento()
        {
            this.Detalle = new List<MantenimientoDetalle>();
        }

        public void AgregarDetalle(int id, int mantenimientoId, int tallerId, int articuloId, string articulo, int cantidad, int precio, int importe)
        {
            this.Detalle.Add(new MantenimientoDetalle(id, mantenimientoId, tallerId, articuloId, articulo, cantidad, precio, importe));
        }
    }
}
