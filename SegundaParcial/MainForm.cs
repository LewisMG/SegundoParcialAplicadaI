using SegundaParcial.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundaParcial
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void registrarTalleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTalleres ver = new rTalleres();
            ver.MdiParent = this;
            ver.Show();
        }

        private void registrarVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos ver = new rVehiculos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void registrarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos ver = new rArticulos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void registrarEntradaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaArticulos ver = new rEntradaArticulos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rTalleres ver = new rTalleres();
            ver.MdiParent = this;
            ver.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rVehiculos ver = new rVehiculos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rArticulos ver = new rArticulos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            rEntradaArticulos ver = new rEntradaArticulos();
            ver.MdiParent = this;
            ver.Show();
        }

        private void registrarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMantenimiento ver = new rMantenimiento();
            ver.MdiParent = this;
            ver.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            rMantenimiento ver = new rMantenimiento();
            ver.MdiParent = this;
            ver.Show();
        }
    }
}
