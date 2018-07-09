namespace SegundaParcial.UI.Registros
{
    partial class rVehiculos
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
            System.Windows.Forms.Label vehiculoIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label mantenimientoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rVehiculos));
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.MantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.vehiculoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            vehiculoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            mantenimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoIdNumericUpDown)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculoIdLabel
            // 
            vehiculoIdLabel.AutoSize = true;
            vehiculoIdLabel.Location = new System.Drawing.Point(12, 24);
            vehiculoIdLabel.Name = "vehiculoIdLabel";
            vehiculoIdLabel.Size = new System.Drawing.Size(63, 13);
            vehiculoIdLabel.TabIndex = 1;
            vehiculoIdLabel.Text = "Vehiculo Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 56);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // mantenimientoLabel
            // 
            mantenimientoLabel.AutoSize = true;
            mantenimientoLabel.Location = new System.Drawing.Point(12, 87);
            mantenimientoLabel.Name = "mantenimientoLabel";
            mantenimientoLabel.Size = new System.Drawing.Size(79, 13);
            mantenimientoLabel.TabIndex = 3;
            mantenimientoLabel.Text = "Mantenimiento:";
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataSource = typeof(SegundoParcial.Entidades.Vehiculos);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Mantenimiento", true));
            this.DescripcionTextBox.Location = new System.Drawing.Point(97, 53);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(155, 20);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // MantenimientoTextBox
            // 
            this.MantenimientoTextBox.Location = new System.Drawing.Point(97, 84);
            this.MantenimientoTextBox.Name = "MantenimientoTextBox";
            this.MantenimientoTextBox.ReadOnly = true;
            this.MantenimientoTextBox.Size = new System.Drawing.Size(155, 20);
            this.MantenimientoTextBox.TabIndex = 38;
            // 
            // vehiculoIdNumericUpDown
            // 
            this.vehiculoIdNumericUpDown.Location = new System.Drawing.Point(97, 22);
            this.vehiculoIdNumericUpDown.Name = "vehiculoIdNumericUpDown";
            this.vehiculoIdNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.vehiculoIdNumericUpDown.TabIndex = 39;
            // 
            // panelBotones
            // 
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.buttonEliminar);
            this.panelBotones.Controls.Add(this.buttonGuardar);
            this.panelBotones.Controls.Add(this.buttonNuevo);
            this.panelBotones.Location = new System.Drawing.Point(12, 126);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(250, 59);
            this.panelBotones.TabIndex = 40;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::SegundaParcial.Properties.Resources.icons8_Delete_Document_32;
            this.buttonEliminar.Location = new System.Drawing.Point(168, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 51);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = global::SegundaParcial.Properties.Resources.icons8_Save_32;
            this.buttonGuardar.Location = new System.Drawing.Point(87, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 51);
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
            this.buttonNuevo.Size = new System.Drawing.Size(75, 51);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::SegundaParcial.Properties.Resources.icons8_Search_16;
            this.buttonBuscar.Location = new System.Drawing.Point(181, 22);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(71, 25);
            this.buttonBuscar.TabIndex = 41;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // rVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 197);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.vehiculoIdNumericUpDown);
            this.Controls.Add(this.MantenimientoTextBox);
            this.Controls.Add(mantenimientoLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(vehiculoIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rVehiculos";
            this.Text = "rVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoIdNumericUpDown)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox MantenimientoTextBox;
        private System.Windows.Forms.NumericUpDown vehiculoIdNumericUpDown;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
    }
}