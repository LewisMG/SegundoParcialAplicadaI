using SegundoParcial.BLL;
using SegundoParcial.DAL;
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
    public partial class rEntradaArticulos : Form
    {
        public rEntradaArticulos()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void rEntradaArticulos_Load(object sender, EventArgs e)
        {

        }

        private EntradaArticulos Llenarclase()
        {
            EntradaArticulos entradaArticulo = new EntradaArticulos();
            entradaArticulo.EntradaId = Convert.ToInt32(EntradaIdNumericUpDown.Value);
            entradaArticulo.Articulo = ArticulosComboBox.Text;
            entradaArticulo.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
            
            return entradaArticulo;
        }

        private void LimpiarCampos()
        {
            EntradaIdNumericUpDown.Value = 0;
            CantidadNumericUpDown.Value = 0;
            
            GeneralErrorProvider.Clear();
        }

        private void LlenarComboBox()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>(new Contexto());
            ArticulosComboBox.DataSource = repositorio.GetList(c => true);
            ArticulosComboBox.ValueMember = "ArticuloId";
            ArticulosComboBox.DisplayMember = "Descripcion";
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && EntradaIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(EntradaIdNumericUpDown, "Introduzca un Id");
                errores = true;
            }

            if (error == 2 && CantidadNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(CantidadNumericUpDown, "Introduzca un Nombre");
                errores = true;
            }
            return errores;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Introducir Id");
            }
            else
            {
                int id = Convert.ToInt32(EntradaIdNumericUpDown.Value);
                EntradaArticulos entradaarticulo = EntradaArticulosBLL.Buscar(id);

                if (entradaarticulo != null)
                {
                    EntradaIdNumericUpDown.Value = entradaarticulo.EntradaId;
                    ArticulosComboBox.Text = entradaarticulo.Articulo;
                    CantidadNumericUpDown.Value = entradaarticulo.Cantidad;
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            EntradaArticulos entradaarticulo = Llenarclase();


            if (validar(2))
            {
                MessageBox.Show("Introduzca los campos Correspondientes");
            }
            else
            {
                if (EntradaIdNumericUpDown.Value == 0)
                {
                    paso = EntradaArticulosBLL.Guardar(entradaarticulo);
                }
                else
                {
                    paso = EntradaArticulosBLL.Modificar(entradaarticulo);
                }
                LimpiarCampos();
                GeneralErrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitosamente", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!", "Fallo!", 
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
                int id = Convert.ToInt32(EntradaIdNumericUpDown.Value);

                if (EntradaArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se Pudo Eliminar!",
                        "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralErrorProvider.Clear();
            }
        }
    }
}
