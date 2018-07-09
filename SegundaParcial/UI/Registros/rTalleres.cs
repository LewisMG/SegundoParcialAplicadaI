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

        private bool Validar()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                GeneralerrorProvider.SetError(NombretextBox,
                     "No debes dejar el nombre vacio");
                HayErrores = true;
            }
            return HayErrores;
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Talleres taller;
            bool Paso = false;

            taller = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (TallerIdNumericUpDown.Value == 0)
                Paso = TalleresBLL.Guardar(taller);
            else
                //validar que exista.
                Paso = TalleresBLL.Modificar(taller);

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

        private void buttonEliminar_Click(object sender, EventArgs e)
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
