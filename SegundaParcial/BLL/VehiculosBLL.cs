﻿using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class VehiculosBLL
    {
        public static bool Guardar(Vehiculos vehiculo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.vehiculos.Add(vehiculo) != null)
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
                Vehiculos vehiculo = contexto.vehiculos.Find(id);

                if (vehiculo != null)
                {
                    contexto.Entry(vehiculo).State = EntityState.Deleted;
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

        public static bool Modificar(Vehiculos vehiculo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(vehiculo).State = EntityState.Modified;

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

        public static Vehiculos Buscar(int id)
        {
            Vehiculos vehiculo = new Vehiculos();
            Contexto contexto = new Contexto();

            try
            {
                vehiculo = contexto.vehiculos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vehiculo;
        }

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
