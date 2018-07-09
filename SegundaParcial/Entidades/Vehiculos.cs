﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Mantenimiento { get; set; }

        public Vehiculos()
        {
            VehiculoId = 0;
            Descripcion = string.Empty;
            Mantenimiento = 0;
        }
    }
}
