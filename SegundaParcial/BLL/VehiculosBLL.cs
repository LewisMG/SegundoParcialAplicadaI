using SegundaParcial.DAL;
using SegundaParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundaParcial.BLL
{
    public class VehiculosBLL
    {
        public static List<Vehiculos> GetList(Expression<Func<Vehiculos, bool>> expression)
        {
            List<Vehiculos> vehiculo = new List<Vehiculos>();
            Contexto contexto = new Contexto();

            try
            {
                vehiculo = contexto.vehiculos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vehiculo;
        }
    }
}
