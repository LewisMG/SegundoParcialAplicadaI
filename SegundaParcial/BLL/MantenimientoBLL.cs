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
    public class MantenimientoBLL
    {
        public static bool Guardar(Mantenimiento mantenimiento)
        {
            bool paso = false;
            Vehiculos vehiculos = new Vehiculos();
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.mantenimiento.Add(mantenimiento) != null)
                {
                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario -= item.Cantidad;
                    }
                    contexto.vehiculos.Find(mantenimiento.VehiculoId).Mantenimiento += Convert.ToInt32(mantenimiento.Total);

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
                Mantenimiento Mantenimiento = contexto.mantenimiento.Find(id);
                
                if (Mantenimiento != null)
                {
                    foreach (var item in Mantenimiento.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario += item.Cantidad;

                    }

                    contexto.vehiculos.Find(Mantenimiento.VehiculoId).Mantenimiento -= Mantenimiento.Total;

                    Mantenimiento.Detalle.Count();
                    contexto.mantenimiento.Remove(Mantenimiento);   
                }
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

        public static Mantenimiento Buscar(int id)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            Contexto contexto = new Contexto();

            try
            {
                mantenimiento = contexto.mantenimiento.Find(id);
                if (mantenimiento != null)
                {
                    mantenimiento.Detalle.Count();

                    foreach (var item in mantenimiento.Detalle)
                    {

                        string s = item.Articulos.Descripcion;
                    }

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return mantenimiento;
        }

        public static bool Modificar(Mantenimiento mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            
            try
            {
                var Mantenimiento = MantenimientoBLL.Buscar(mantenimiento.MantenimientoId);
                
                if (Mantenimiento != null)
                {
                    foreach (var item in Mantenimiento.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario += item.Cantidad;
                        
                        if (!mantenimiento.Detalle.ToList().Exists(v => v.Id == item.Id))
                        {
                            item.Articulos = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }
                    }
                    
                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario -= item.Cantidad;
                        
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }

                    Mantenimiento EntradaAnterior = Buscar(mantenimiento.MantenimientoId);
                    
                    //Identificar la diferencia ya sea restada o sumada
                    decimal diferencia;

                    diferencia = mantenimiento.Total - EntradaAnterior.Total;

                    //Aplicar diferencia al inventario
                    Vehiculos vehiculos = VehiculosBLL.Buscar(mantenimiento.VehiculoId);
                    vehiculos.Mantenimiento += diferencia;
                    VehiculosBLL.Modificar(vehiculos);
                    
                    contexto.Entry(mantenimiento).State = EntityState.Modified;
                }
                
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

        public static List<Mantenimiento> GetList(Expression<Func<Mantenimiento, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Mantenimiento> mantenimiento = new List<Mantenimiento>();

            try
            {
                mantenimiento = contexto.mantenimiento.Where(expression).ToList();

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return mantenimiento;

        }

        public static decimal CalcularImporte(decimal precio, int cantidad)
        {
            return Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
        }

        public static decimal CalcularItbis(decimal subtotal)
        {
            return Convert.ToDecimal(subtotal) * Convert.ToDecimal(0.18);
        }

        public static decimal CalcularTotal(decimal subtotal, decimal itbis)
        {
            return Convert.ToDecimal(subtotal) + Convert.ToDecimal(itbis);
        }
    }
}
