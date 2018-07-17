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
    public partial class rVehiculos : Form
    {
        public rVehiculos()
        {
            InitializeComponent();
        }

        private Vehiculos Llenaclase()
        {
            MantenimientoTextBox.Text = 0.ToString();
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.VehiculoId = Convert.ToInt32(vehiculoIdNumericUpDown.Value);
            vehiculo.Descripcion = DescripcionTextBox.Text;
            vehiculo.Mantenimiento = Convert.ToDecimal(MantenimientoTextBox.Text);

            return vehiculo;
        }

        private void LimpiarCampos()
        {
            vehiculoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            MantenimientoTextBox.Clear();
            GeneralErrorProvider.Clear();
        }

        private bool validar(int error)
        {
            bool paso = false;

            if (error == 1 && vehiculoIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(vehiculoIdNumericUpDown, 
                    "Introduzca un Id");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                GeneralErrorProvider.SetError(DescripcionTextBox, 
                    "Introduzca una Descripcion");
                paso = true;
            }

            return paso;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Introduzca Id A Buscar");
            }
            else
            {
                int id = Convert.ToInt32(vehiculoIdNumericUpDown.Value);
                Vehiculos vehiculos = VehiculosBLL.Buscar(id);

                if (vehiculos != null)
                {
                    vehiculoIdNumericUpDown.Value = vehiculos.VehiculoId;
                    DescripcionTextBox.Text = vehiculos.Descripcion;
                    MantenimientoTextBox.Text = vehiculos.Mantenimiento.ToString();
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
            Vehiculos vehiculos = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Llene las casillas correspondientes");
            }
            else
            {
                if (vehiculoIdNumericUpDown.Value == 0)
                {
                    paso = VehiculosBLL.Guardar(vehiculos);
                }
                else
                {
                   
                    int id = Convert.ToInt32(vehiculoIdNumericUpDown.Value);
                    var mantenimientos = VehiculosBLL.Buscar(id);
                    if (mantenimientos != null)
                    {
                        paso = VehiculosBLL.Modificar(vehiculos);
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
                MessageBox.Show("Favor Introducir Id A Eliminar!");
            }
            else
            {
                int id = Convert.ToInt32(vehiculoIdNumericUpDown.Value);

                if (VehiculosBLL.Eliminar(id))
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
    }
}
