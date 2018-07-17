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
    public partial class rTalleres : Form
    {
        public rTalleres()
        {
            InitializeComponent();
        }

        private Talleres LlenaClase()
        {
            Talleres taller = new Talleres();

            taller.TallerId = Convert.ToInt32(TallerIdNumericUpDown.Value);
            taller.Nombre = NombretextBox.Text;

            return taller;
        }

        private void LimpiarCampos()
        {
            TallerIdNumericUpDown.Value = 0;
            NombretextBox.Clear();
        }

        private bool Validar(int error)
        {
            bool errores = false;

            if (error == 1 && TallerIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(TallerIdNumericUpDown, "Introduzcca un Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(NombretextBox.Text))
            {
                GeneralErrorProvider.SetError(NombretextBox, "Introduzca un Nombre");
                errores = true;
            }
            return errores;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar (Talleres Id) para poder Buscar");
            }
            else
            {

                int id = Convert.ToInt32(TallerIdNumericUpDown.Value);
                Talleres taller = TalleresBLL.Buscar(id);

                if (taller != null)
                {
                    NombretextBox.Text = taller.Nombre;
                }
                else
                    MessageBox.Show("No se encontro!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Talleres taller;
            bool Paso = false;

            if (Validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                int id = Convert.ToInt32(TallerIdNumericUpDown.Value);
                var mantenimientos = TalleresBLL.Buscar(id);
                taller = LlenaClase();

                //Determinar si es Guardar o Modificar
                if (TallerIdNumericUpDown.Value == 0)
                    Paso = TalleresBLL.Guardar(taller);
                else
                //validar que exista.

                if (mantenimientos != null)
                {
                    Paso = TalleresBLL.Modificar(taller);
                }


                //Informar el resultado
                if (Paso)
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Para Luego que guarden algo los campos se limpien
                LimpiarCampos();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar (Vehiculos Id) para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(TallerIdNumericUpDown.Value);

                //validar que exista
                if (TalleresBLL.Eliminar(id))
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Para Luego que guarden algo los campos se limpien
                LimpiarCampos();
            }
        }
    }
}
