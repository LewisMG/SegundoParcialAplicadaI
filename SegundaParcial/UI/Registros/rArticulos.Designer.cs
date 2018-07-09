namespace SegundaParcial.UI.Registros
{
    partial class rArticulos
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
            System.Windows.Forms.Label articuloIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label gananciaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label inventarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rArticulos));
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArticuloIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GananciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InventarioTextBox = new System.Windows.Forms.TextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            articuloIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            gananciaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            inventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // articuloIdLabel
            // 
            articuloIdLabel.AutoSize = true;
            articuloIdLabel.Location = new System.Drawing.Point(12, 29);
            articuloIdLabel.Name = "articuloIdLabel";
            articuloIdLabel.Size = new System.Drawing.Size(57, 13);
            articuloIdLabel.TabIndex = 1;
            articuloIdLabel.Text = "Articulo Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 63);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(12, 106);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(37, 13);
            costoLabel.TabIndex = 4;
            costoLabel.Text = "Costo:";
            // 
            // gananciaLabel
            // 
            gananciaLabel.AutoSize = true;
            gananciaLabel.Location = new System.Drawing.Point(236, 106);
            gananciaLabel.Name = "gananciaLabel";
            gananciaLabel.Size = new System.Drawing.Size(67, 13);
            gananciaLabel.TabIndex = 6;
            gananciaLabel.Text = "Ganancia %:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(12, 148);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 8;
            precioLabel.Text = "Precio:";
            // 
            // inventarioLabel
            // 
            inventarioLabel.AutoSize = true;
            inventarioLabel.Location = new System.Drawing.Point(236, 148);
            inventarioLabel.Name = "inventarioLabel";
            inventarioLabel.Size = new System.Drawing.Size(57, 13);
            inventarioLabel.TabIndex = 10;
            inventarioLabel.Text = "Inventario:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosBindingSource, "Descripcion", true));
            this.DescripcionTextBox.Location = new System.Drawing.Point(84, 63);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(120, 20);
            this.DescripcionTextBox.TabIndex = 2;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataSource = typeof(SegundoParcial.Entidades.Articulos);
            // 
            // ArticuloIdNumericUpDown
            // 
            this.ArticuloIdNumericUpDown.Location = new System.Drawing.Point(84, 29);
            this.ArticuloIdNumericUpDown.Name = "ArticuloIdNumericUpDown";
            this.ArticuloIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArticuloIdNumericUpDown.TabIndex = 3;
            // 
            // CostoNumericUpDown
            // 
            this.CostoNumericUpDown.Location = new System.Drawing.Point(84, 104);
            this.CostoNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CostoNumericUpDown.Name = "CostoNumericUpDown";
            this.CostoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CostoNumericUpDown.TabIndex = 5;
            this.CostoNumericUpDown.ValueChanged += new System.EventHandler(this.CostoNumericUpDown_ValueChanged_1);
            // 
            // GananciaNumericUpDown
            // 
            this.GananciaNumericUpDown.Location = new System.Drawing.Point(308, 106);
            this.GananciaNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.GananciaNumericUpDown.Name = "GananciaNumericUpDown";
            this.GananciaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.GananciaNumericUpDown.TabIndex = 7;
            this.GananciaNumericUpDown.ValueChanged += new System.EventHandler(this.GananciaNumericUpDown_ValueChanged);
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(84, 146);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecioNumericUpDown.TabIndex = 9;
            this.PrecioNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioNumericUpDown_ValueChanged_1);
            // 
            // InventarioTextBox
            // 
            this.InventarioTextBox.Location = new System.Drawing.Point(308, 148);
            this.InventarioTextBox.Name = "InventarioTextBox";
            this.InventarioTextBox.ReadOnly = true;
            this.InventarioTextBox.Size = new System.Drawing.Size(120, 20);
            this.InventarioTextBox.TabIndex = 13;
            // 
            // panelBotones
            // 
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.buttonEliminar);
            this.panelBotones.Controls.Add(this.buttonGuardar);
            this.panelBotones.Controls.Add(this.buttonNuevo);
            this.panelBotones.Location = new System.Drawing.Point(12, 211);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(416, 59);
            this.panelBotones.TabIndex = 53;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::SegundaParcial.Properties.Resources.icons8_Delete_Document_32;
            this.buttonEliminar.Location = new System.Drawing.Point(318, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(93, 51);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = global::SegundaParcial.Properties.Resources.icons8_Save_32;
            this.buttonGuardar.Location = new System.Drawing.Point(154, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 51);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Image = global::SegundaParcial.Properties.Resources.icons8_Add_Property_32;
            this.buttonNuevo.Location = new System.Drawing.Point(3, 3);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(93, 51);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::SegundaParcial.Properties.Resources.icons8_Search_16;
            this.buttonBuscar.Location = new System.Drawing.Point(210, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(82, 25);
            this.buttonBuscar.TabIndex = 54;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // rArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 286);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.InventarioTextBox);
            this.Controls.Add(inventarioLabel);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.GananciaNumericUpDown);
            this.Controls.Add(gananciaLabel);
            this.Controls.Add(this.CostoNumericUpDown);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.ArticuloIdNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(articuloIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rArticulos";
            this.Text = "rArticulos";
            this.Load += new System.EventHandler(this.rArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GananciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource articulosBindingSource;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown ArticuloIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown CostoNumericUpDown;
        private System.Windows.Forms.NumericUpDown GananciaNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.TextBox InventarioTextBox;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}