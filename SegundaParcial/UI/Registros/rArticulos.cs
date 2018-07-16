using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundaParcial.UI.Registros
{
    public partial class rArticulos : Form
    {
        public rArticulos()
        {
            InitializeComponent();
            InventarioTextBox.Text = 0.ToString();
        }

        private Articulos Llenaclase()
        {
            Articulos articulo = new Articulos();
                        
            articulo.ArticuloId = Convert.ToInt32(ArticuloIdNumericUpDown.Value);
            articulo.Descripcion = DescripcionTextBox.Text;
            articulo.Costo = Convert.ToInt32(CostoNumericUpDown.Value);
            articulo.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            articulo.Ganancia = Convert.ToInt32(GananciaNumericUpDown.Value);
            InventarioTextBox.Text = 0.ToString();
            articulo.Inventario = Convert.ToInt32(InventarioTextBox.Text);

            return articulo;
        }

        private void LimpiarCampos()
        {
            ArticuloIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            CostoNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            GananciaNumericUpDown.Value = 0;
            InventarioTextBox.Clear();
            InventarioTextBox.Text = 0.ToString();
            
            GeneralErrorProvider.Clear();
        }

        private bool validar(int error)
        {
            bool paso = false;

            if (error == 1 && ArticuloIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(ArticuloIdNumericUpDown, 
                    "Introduzca Id");
                paso = true;
            }

            if (error == 2 && PrecioNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(PrecioNumericUpDown, 
                    "Introduzca El Precio");
                paso = true;
            }

            if (error == 2 && GananciaNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(GananciaNumericUpDown, 
                    "Introduzca La Ganancia");
                paso = true;
            }

            if (error == 2 && CostoNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(CostoNumericUpDown, 
                    "Introduzca El Costo");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                GeneralErrorProvider.SetError(DescripcionTextBox, 
                    "Introduzca La Descripcion");
                paso = true;
            }

            return paso;
        }

        private void rArticulos_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Introduzca El Id A Buscar!");
            }
            else
            {
                int id = Convert.ToInt32(ArticuloIdNumericUpDown.Value);
                Articulos articulo = ArticulosBLL.Buscar(id);

                if (articulo != null)
                {
                    ArticuloIdNumericUpDown.Value = articulo.ArticuloId;
                    DescripcionTextBox.Text = articulo.Descripcion;
                    CostoNumericUpDown.Value = articulo.Costo;
                    PrecioNumericUpDown.Value = articulo.Precio;
                    GananciaNumericUpDown.Value = articulo.Ganancia;
                    InventarioTextBox.Text = articulo.Inventario.ToString();
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulo = Llenaclase();

            if (validar(2))
            {
                MessageBox.Show("Introduzca Las Casillas Correspondientes!");
            }
            else
            {
                if (ArticuloIdNumericUpDown.Value == 0)
                {
                    paso = ArticulosBLL.Guardar(articulo);
                }
                else
                {
                    int id = Convert.ToInt32(ArticuloIdNumericUpDown.Value);
                    Articulos articulos = ArticulosBLL.Buscar(id);
                    if (articulos != null)
                    {
                        paso = ArticulosBLL.Modificar(articulo);
                    }
                    else
                    {
                        MessageBox.Show("Id No Encotrado!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LimpiarCampos();
                GeneralErrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Introduzca Un Id");
            }
            else
            {
                int id = Convert.ToInt32(ArticuloIdNumericUpDown.Value);

                if (ArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }
  
        private void PrecioNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostoNumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GananciaNumericUpDown.Value);

            if (PrecioNumericUpDown.Value > CostoNumericUpDown.Value && GananciaNumericUpDown.Value == 0)
            {
                GananciaNumericUpDown.Value = ArticulosBLL.CalcularGanancia(costo, precio);

            }
            else
            if (PrecioNumericUpDown.Value > 0 && GananciaNumericUpDown.Value > 0 && CostoNumericUpDown.Value == 0)
            {

                CostoNumericUpDown.Value = ArticulosBLL.CalcularCosto(ganancia, precio);
            }
        }

        private void CostoNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(CostoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GananciaNumericUpDown.Value);

            if (CostoNumericUpDown.Value < PrecioNumericUpDown.Value && GananciaNumericUpDown.Value == 0)
            {
                GananciaNumericUpDown.Value = ArticulosBLL.CalcularGanancia(costo, costo);
            }
            if (CostoNumericUpDown.Value > 0 && GananciaNumericUpDown.Value > 0 && PrecioNumericUpDown.Value == 0)
            {
                PrecioNumericUpDown.Value = ArticulosBLL.CalcularPrecio(costo, ganancia);
            }
        }

        private void GananciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(CostoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GananciaNumericUpDown.Value);


            if (CostoNumericUpDown.Value > 0 && GananciaNumericUpDown.Value > 0 && PrecioNumericUpDown.Value == 0)
            {
                PrecioNumericUpDown.Value = ArticulosBLL.CalcularPrecio(costo, ganancia);
            }
            if (PrecioNumericUpDown.Value > 0 && GananciaNumericUpDown.Value > 0 && CostoNumericUpDown.Value == 0)
            {
                CostoNumericUpDown.Value = ArticulosBLL.CalcularCosto(ganancia, precio);
            }
        }
    }
}
