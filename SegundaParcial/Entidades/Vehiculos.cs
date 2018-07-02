using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundaParcial.Entidades
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Descripcion { get; set; }
        public float Mantenimiento { get; set; }

        public virtual List<Mantenimiento> Detalle { get; set; }

        public Vehiculos()
        {
            this.Detalle = new List<Mantenimiento>();
        }


        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
