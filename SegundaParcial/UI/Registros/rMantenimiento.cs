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
    public partial class rMantenimiento : Form
    {
        decimal itbis = 0;
        decimal Total = 0;
       
        public rMantenimiento()
        {
            InitializeComponent();
            LlenarComboBox();
            Meses();
        }

        private void rMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }

        private Mantenimiento LlenaClase()
        {
            Mantenimiento Mantenimiento = new Mantenimiento();

            Mantenimiento.MantenimientoId = Convert.ToInt32(MantenimientoIdNumericUpDown.Value);
            Mantenimiento.VehiculoId = Convert.ToInt32(VehiculoComboBox.SelectedValue);
            Mantenimiento.Fecha = FechaDateTimePicker.Value;
            Mantenimiento.Subtotal = Convert.ToDecimal(SubtotalTextBox.Text);
            Mantenimiento.itbis = Convert.ToDecimal(ITBISTextBox.Text);
            Mantenimiento.Total = Convert.ToDecimal(TotalTextBox.Text);

            foreach (DataGridViewRow item in DetalleDataGridView.Rows)
            {

                Mantenimiento.AgregarDetalle
                (ToInt(item.Cells["id"].Value),
                Mantenimiento.MantenimientoId,
                ToInt(item.Cells["tallerId"].Value),
                ToInt(item.Cells["articuloId"].Value),
                Convert.ToString(item.Cells["Articulo"].Value),
                ToInt(item.Cells["cantidad"].Value),
                ToInt(item.Cells["precio"].Value),
                ToInt(item.Cells["importe"].Value)
                  );
            }
            return Mantenimiento;
        }

        public void LimpiarCampos()
        {
            MantenimientoIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            CantidadNumericUpDown.Value = 0;
            TotalTextBox.Clear();

            ImporteTextBox.Clear();
            SubtotalTextBox.Text = 0.ToString();
            TotalTextBox.Text = 0.ToString();
            ITBISTextBox.Text = 0.ToString();
            DetalleDataGridView.DataSource = null;

            itbis = 0;
            
            Total = 0;
           

            GeneralErrorProvider.Clear();
        }

        private void LlenarComboBox()
        {
            Repositorio<Vehiculos> vehiculo = new Repositorio<Vehiculos>(new Contexto());
            VehiculoComboBox.DataSource = vehiculo.GetList(c => true);
            VehiculoComboBox.ValueMember = "VehiculoId";
            VehiculoComboBox.DisplayMember = "Descripcion";

            Repositorio<Talleres> taller = new Repositorio<Talleres>(new Contexto());
            TallerComboBox.DataSource = taller.GetList(c => true);
            TallerComboBox.ValueMember = "TallerId";
            TallerComboBox.DisplayMember = "Nombre";

            Repositorio<Articulos> Entrada = new Repositorio<Articulos>(new Contexto());
            ArticulosComboBox.DataSource = Entrada.GetList(c => true);
            ArticulosComboBox.ValueMember = "ArticuloId";
            ArticulosComboBox.DisplayMember = "Descripcion";
        }

        public void QuitarColumnas()
        {
            DetalleDataGridView.Columns["ArticuloId"].Visible = false;
            DetalleDataGridView.Columns["Articulos"].Visible = false;
            DetalleDataGridView.Columns["Talleres"].Visible = false;
            DetalleDataGridView.Columns["VehiculoId"].Visible = false;
            DetalleDataGridView.Columns["articulo"].DisplayIndex = 1;
            DetalleDataGridView.Columns["TallerId"].Visible = false;
            DetalleDataGridView.Columns["mantenimientoId"].Visible = false;
            DetalleDataGridView.Columns["id"].Visible = false;
        }

        private void LlenarCampos(Mantenimiento Mantenimiento)
        {
            LimpiarCampos();
            MantenimientoIdNumericUpDown.Value = Mantenimiento.MantenimientoId;
            FechaDateTimePicker.Value = Mantenimiento.Fecha;
            SubtotalTextBox.Text = Mantenimiento.Subtotal.ToString();
            ITBISTextBox.Text = Mantenimiento.itbis.ToString();
            TotalTextBox.Text = Mantenimiento.Total.ToString();

           

            DetalleDataGridView.DataSource = Mantenimiento.Detalle;

            QuitarColumnas();
        }

        private void Meses()
        {
            ProximoMantenimientoDateTimePicker.Value = FechaDateTimePicker.Value.AddMonths(3);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(MantenimientoIdNumericUpDown.Value);
            Mantenimiento mantenimiento = MantenimientoBLL.Buscar(id);

            if (mantenimiento != null)
            {
                LlenarCampos(mantenimiento);

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
            if (Validar(2))
            {
                MessageBox.Show("Debe Agregar Algun Producto al Grid", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Mantenimiento mantenimiento = LlenaClase();
                bool Paso = false;

                if (MantenimientoIdNumericUpDown.Value == 0)
                {
                    Paso = MantenimientoBLL.Guardar(mantenimiento);
                    GeneralErrorProvider.Clear();
                }
                else
                {
                    int id = Convert.ToInt32(MantenimientoIdNumericUpDown.Value);
                    var mantenimientos = MantenimientoBLL.Buscar(id);
                    if (mantenimientos != null)
                    {
                        Paso = MantenimientoBLL.Modificar(mantenimiento);
                    }
                    GeneralErrorProvider.Clear();
                }
                
                if (Paso)
                {
                    LimpiarCampos();
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor Llenar Casilla!", "Exito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(MantenimientoIdNumericUpDown.Value);
                if (MantenimientoBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            List<MantenimientoDetalle> Detalle = new List<MantenimientoDetalle>();
            
            if (DetalleDataGridView.DataSource != null)
            {
                Detalle = (List<MantenimientoDetalle>)DetalleDataGridView.DataSource;
            }

            foreach (var item in ArticulosBLL.GetList(x => x.Inventario < CantidadNumericUpDown.Value))
            {

                MessageBox.Show("No Dispone de esa cantidad", "Verificacion", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ImporteTextBox.Text))
            {
                MessageBox.Show("EL Importe Se Encuentra vacio, Introduzca la cantidad", 
                    "Verificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Detalle.Add(
                    new MantenimientoDetalle(id: 0,
                    mantenimientoId: (int)Convert.ToInt32(MantenimientoIdNumericUpDown.Value),
                    tallerId: (int)TallerComboBox.SelectedValue,
                    articuloId: (int)ArticulosComboBox.SelectedValue,
                    articulo: (string)ArticulosBLL.RetornarDescripcion(ArticulosComboBox.Text),
                    cantidad: (int)Convert.ToInt32(CantidadNumericUpDown.Value),
                    precio: (int)Convert.ToInt32(PrecioTextBox.Text),
                    importe: (int)Convert.ToInt32(ImporteTextBox.Text)

                    ));

                //Cargar el detalle al Grid
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = Detalle;

                //Oculta las Columnas No deceada
                QuitarColumnas();
            }

            decimal subtotal = 0;

            foreach (var item in Detalle)
            {
                subtotal += item.Importe;
            }

            SubtotalTextBox.Text = subtotal.ToString();

            itbis = MantenimientoBLL.CalcularItbis(Convert.ToDecimal(SubtotalTextBox.Text));

            ITBISTextBox.Text = itbis.ToString();

            Total = MantenimientoBLL.CalcularTotal(Convert.ToDecimal(SubtotalTextBox.Text), Convert.ToDecimal(ITBISTextBox.Text));

            TotalTextBox.Text = Total.ToString();
        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                List<MantenimientoDetalle> detalle = (List<MantenimientoDetalle>)DetalleDataGridView.DataSource;
                
                //remover la fila
                detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);

                decimal subtotal = 0;
                foreach (var item in detalle)
                {
                    subtotal += item.Importe;
                }
                SubtotalTextBox.Text = subtotal.ToString();

                itbis = MantenimientoBLL.CalcularItbis(Convert.ToDecimal(SubtotalTextBox.Text));
                ITBISTextBox.Text = itbis.ToString();

                Total = MantenimientoBLL.CalcularTotal(Convert.ToDecimal(SubtotalTextBox.Text), Convert.ToDecimal(ITBISTextBox.Text));

                TotalTextBox.Text = Total.ToString();

                // Cargar el detalle al Grid
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = detalle;
                
                QuitarColumnas();
            }
        }

        private void ArticulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ArticulosBLL.GetList(x => x.Descripcion == ArticulosComboBox.Text))
            {
                PrecioTextBox.Text = item.Precio.ToString();
            }
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImporteTextBox.Text = MantenimientoBLL.CalcularImporte(Convert.ToDecimal(PrecioTextBox.Text), 
                Convert.ToInt32(CantidadNumericUpDown.Value)).ToString(); 
        }

        private bool Validar(int error)
        {
            bool paso = false;
            
            if (error == 1 && MantenimientoIdNumericUpDown.Value == 0)
            {
                GeneralErrorProvider.SetError(MantenimientoIdNumericUpDown,
                  "Favor Introduzca Un Id");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(SubtotalTextBox.Text))
            {
                GeneralErrorProvider.SetError(SubtotalTextBox,
                   "Favor Introducir SubTotal!");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(ITBISTextBox.Text))
            {
                GeneralErrorProvider.SetError(ITBISTextBox,
                   "Favor Introducir ITBIS!");
                paso = true;
            }

            if (error == 2 && DetalleDataGridView.RowCount == 0)
            {
                GeneralErrorProvider.SetError(DetalleDataGridView,
                    "Es obligatorio Agregar un Articulo");
                paso = true;
            }

            if (error == 3 && string.IsNullOrEmpty(ImporteTextBox.Text))
            {
                GeneralErrorProvider.SetError(ImporteTextBox,
                    "Es obligatorio Agregar un Articulo");
                paso = true;
            }

            return paso;
        }

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Meses();
        }
    }
}
