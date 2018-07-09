namespace SegundaParcial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.registrarTalleresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEntradaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivoToolStripMenuItem.Text = "Archivos";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTalleresToolStripMenuItem,
            this.registrarVehiculosToolStripMenuItem,
            this.registrarArticulosToolStripMenuItem,
            this.registrarEntradaDeArticulosToolStripMenuItem,
            this.registrarMantenimientoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Registrar Talleres";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Registrar Vehiculos";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Registrar Articulos";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Registar Entrada de Articulos";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Registrar Mantenimiento";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // registrarTalleresToolStripMenuItem
            // 
            this.registrarTalleresToolStripMenuItem.Image = global::SegundaParcial.Properties.Resources.icons8_Support_16;
            this.registrarTalleresToolStripMenuItem.Name = "registrarTalleresToolStripMenuItem";
            this.registrarTalleresToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registrarTalleresToolStripMenuItem.Text = "Registrar Talleres";
            this.registrarTalleresToolStripMenuItem.Click += new System.EventHandler(this.registrarTalleresToolStripMenuItem_Click);
            // 
            // registrarVehiculosToolStripMenuItem
            // 
            this.registrarVehiculosToolStripMenuItem.Image = global::SegundaParcial.Properties.Resources.icons8_Traffic_Jam_16;
            this.registrarVehiculosToolStripMenuItem.Name = "registrarVehiculosToolStripMenuItem";
            this.registrarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registrarVehiculosToolStripMenuItem.Text = "Registrar Vehiculos";
            this.registrarVehiculosToolStripMenuItem.Click += new System.EventHandler(this.registrarVehiculosToolStripMenuItem_Click);
            // 
            // registrarArticulosToolStripMenuItem
            // 
            this.registrarArticulosToolStripMenuItem.Image = global::SegundaParcial.Properties.Resources.icons8_Wheel_16;
            this.registrarArticulosToolStripMenuItem.Name = "registrarArticulosToolStripMenuItem";
            this.registrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registrarArticulosToolStripMenuItem.Text = "Registrar Articulos";
            this.registrarArticulosToolStripMenuItem.Click += new System.EventHandler(this.registrarArticulosToolStripMenuItem_Click);
            // 
            // registrarEntradaDeArticulosToolStripMenuItem
            // 
            this.registrarEntradaDeArticulosToolStripMenuItem.Image = global::SegundaParcial.Properties.Resources.icons8_Plus_16;
            this.registrarEntradaDeArticulosToolStripMenuItem.Name = "registrarEntradaDeArticulosToolStripMenuItem";
            this.registrarEntradaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registrarEntradaDeArticulosToolStripMenuItem.Text = "Registrar Entrada de Articulos";
            this.registrarEntradaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.registrarEntradaDeArticulosToolStripMenuItem_Click);
            // 
            // registrarMantenimientoToolStripMenuItem
            // 
            this.registrarMantenimientoToolStripMenuItem.Image = global::SegundaParcial.Properties.Resources.icons8_Maintenance_32;
            this.registrarMantenimientoToolStripMenuItem.Name = "registrarMantenimientoToolStripMenuItem";
            this.registrarMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registrarMantenimientoToolStripMenuItem.Text = "Registrar Mantenimiento";
            this.registrarMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.registrarMantenimientoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTalleresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntradaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem registrarMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}



