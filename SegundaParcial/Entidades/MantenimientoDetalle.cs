﻿using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class MantenimientoDetalle
    {
        [Key]

        public int Id { get; set; }
        public int MantenimientoId { get; set; }
        public int VehiculoId { get; set; }
        public int TallerId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
        public string Articulo { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulos { get; set; }

        //[ForeignKey("VehiculoId")]
        //public virtual Vehiculos Vehiculos { get; set; }

        [ForeignKey("TallerId")]
        public virtual Talleres Talleres { get; set; }

        public MantenimientoDetalle() 
        {
            Id = 0;
            MantenimientoId = 0;
        }

        public MantenimientoDetalle(int id, int mantenimientoId, int tallerId, int articuloId, string articulo, int cantidad, int precio, int importe)
        {
            Id = id;
            MantenimientoId = mantenimientoId;
            TallerId = tallerId;
            ArticuloId = articuloId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }

        public MantenimientoDetalle(int mantenimientoId, int articuloId, int cantidad, int precio, int importe, Articulos articulos)
        {
            MantenimientoId = mantenimientoId;
            ArticuloId = articuloId;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
            Articulos = articulos;
        }
    }
}
