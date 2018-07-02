namespace SegundaParcial.UI.Consultas
{
    partial class cPersonas
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
            this.CotizaciondataGridView = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CotizaciondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CotizaciondataGridView
            // 
            this.CotizaciondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CotizaciondataGridView.Location = new System.Drawing.Point(12, 138);
            this.CotizaciondataGridView.Name = "CotizaciondataGridView";
            this.CotizaciondataGridView.Size = new System.Drawing.Size(523, 194);
            this.CotizaciondataGridView.TabIndex = 82;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::SegundaParcial.Properties.Resources.icons8_Delete_Document_32;
            this.buttonEliminar.Location = new System.Drawing.Point(438, 418);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(96, 58);
            this.buttonEliminar.TabIndex = 87;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = global::SegundaParcial.Properties.Resources.icons8_Save_32;
            this.buttonGuardar.Location = new System.Drawing.Point(220, 418);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(96, 58);
            this.buttonGuardar.TabIndex = 86;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Image = global::SegundaParcial.Properties.Resources.icons8_Add_Property_32;
            this.buttonNuevo.Location = new System.Drawing.Point(12, 418);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(96, 58);
            this.buttonNuevo.TabIndex = 85;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::SegundaParcial.Properties.Resources.icons8_Search_16;
            this.buttonBuscar.Location = new System.Drawing.Point(141, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar.TabIndex = 84;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::SegundaParcial.Properties.Resources.icons8_Add_List_16;
            this.buttonAgregar.Location = new System.Drawing.Point(459, 86);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 83;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // cPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 488);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.CotizaciondataGridView);
            this.Name = "cPersonas";
            this.Text = "rDetalle";
            this.Load += new System.EventHandler(this.cPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CotizaciondataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CotizaciondataGridView;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}