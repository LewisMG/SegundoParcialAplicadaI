using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.articulos.Add(articulo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos articulo = contexto.articulos.Find(id);

                if (articulo != null)
                {
                    contexto.Entry(articulo).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Articulos articulo)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Articulos Buscar(int id)
        {

            Articulos articulo = new Articulos();
            Contexto contexto = new Contexto();

            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;

        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulo = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                articulo = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }

        public static decimal CalcularGanancia(decimal precio, decimal costo)
        {
            precio *= (1) ;

            return (Convert.ToDecimal(precio) / Convert.ToDecimal(costo)) * 100;
        }

        public static decimal CalcularPrecio(decimal costo, decimal ganancia)
        {
            ganancia /= 100;
            ganancia *= costo;
            return Convert.ToDecimal(costo) + Convert.ToDecimal(ganancia);
        }

        public static decimal CalcularCosto(decimal precio, decimal ganancia)
        {
            ganancia /= 100;

            return Convert.ToDecimal(precio) * Convert.ToDecimal(ganancia);
        }

        public static string RetornarDescripcion(string nombre)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Descripcion.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Descripcion;
            }

            return descripcion;
        }
    }
}
