using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class EntradaArticulos
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ArticuloID { get; set; }
        public int Cantidad { get; set; }

        public EntradaArticulos()
        {
            Fecha = DateTime.Now;
        }
        
    }
}
