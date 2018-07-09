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
    public class TalleresBLL
    {
        public static bool Guardar(Talleres taller)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.talleres.Add(taller) != null)
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


        public static bool Modificar(Talleres taller)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(taller).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                { paso = true; }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Talleres taller = contexto.talleres.Find(Id);
                contexto.talleres.Remove(taller);

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

        public static Talleres Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Talleres taller = new Talleres();

            try
            {
                taller = contexto.talleres.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return taller;
        }

        public static List<Talleres> GetList(Expression<Func<Talleres, bool>> expression)
        {
            List<Talleres> taller = new List<Talleres>();
            Contexto contexto = new Contexto();

            try
            {
                taller = contexto.talleres.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return taller;
        }

    }
}
