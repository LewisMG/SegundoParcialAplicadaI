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
    public class EntradaArticulosBLL
    {
        public static bool Guardar(EntradaArticulos entradaArticulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Repositorio<Articulos> articulo = new Repositorio<Articulos>(new Contexto());

            try
            {

                if (contexto.entradaArticulos.Add(entradaArticulo) != null)
                {


                    foreach (var item in articulo.GetList(x => x.Descripcion == entradaArticulo.Articulo))
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario += entradaArticulo.Cantidad;
                    }

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
                EntradaArticulos entradaArticulos = contexto.entradaArticulos.Find(id);

                if (entradaArticulos != null)
                {
                    contexto.Entry(entradaArticulos).State = EntityState.Deleted;
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

        public static bool Modificar(EntradaArticulos entradaArticulos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(entradaArticulos).State = EntityState.Modified;

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

        public static EntradaArticulos Buscar(int id)
        {

            EntradaArticulos entradaArticulos = new EntradaArticulos();
            Contexto contexto = new Contexto();

            try
            {
                entradaArticulos = contexto.entradaArticulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entradaArticulos;

        }
        
        public static List<EntradaArticulos> GetList(Expression<Func<EntradaArticulos, bool>> expression)
        {
            List<EntradaArticulos> entradaArticulos = new List<EntradaArticulos>();
            Contexto contexto = new Contexto();

            try
            {
                entradaArticulos = contexto.entradaArticulos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return entradaArticulos;
        }
    }
}
