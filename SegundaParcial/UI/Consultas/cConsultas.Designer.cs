﻿namespace SegundaParcial.UI.Consultas
{
    partial class cConsultas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.filtrarcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fechaspanel = new System.Windows.Forms.Panel();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Fechaspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CriteriotextBox);
            this.groupBox1.Controls.Add(this.filtrarcomboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(556, 41);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriteriotextBox.Location = new System.Drawing.Point(224, 14);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(328, 20);
            this.CriteriotextBox.TabIndex = 3;
            this.CriteriotextBox.TextChanged += new System.EventHandler(this.CriteriotextBox_TextChanged);
            // 
            // filtrarcomboBox
            // 
            this.filtrarcomboBox.FormattingEnabled = true;
            this.filtrarcomboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Cedula",
            "Direccion",
            "Telefono"});
            this.filtrarcomboBox.Location = new System.Drawing.Point(44, 13);
            this.filtrarcomboBox.Name = "filtrarcomboBox";
            this.filtrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarcomboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Filtrar usando Rango de fechas";
            // 
            // Fechaspanel
            // 
            this.Fechaspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fechaspanel.Controls.Add(this.HastadateTimePicker);
            this.Fechaspanel.Controls.Add(this.label3);
            this.Fechaspanel.Controls.Add(this.DesdedateTimePicker);
            this.Fechaspanel.Controls.Add(this.label6);
            this.Fechaspanel.Location = new System.Drawing.Point(192, 56);
            this.Fechaspanel.Margin = new System.Windows.Forms.Padding(2);
            this.Fechaspanel.Name = "Fechaspanel";
            this.Fechaspanel.Size = new System.Drawing.Size(391, 30);
            this.Fechaspanel.TabIndex = 48;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(247, 6);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.HastadateTimePicker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(41, 6);
            this.DesdedateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.DesdedateTimePicker.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde";
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(11, 91);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(636, 290);
            this.ConsultadataGridView.TabIndex = 49;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Image = global::SegundaParcial.Properties.Resources.icons8_Send_to_Printer_32;
            this.buttonImprimir.Location = new System.Drawing.Point(11, 387);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(96, 51);
            this.buttonImprimir.TabIndex = 51;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::SegundaParcial.Properties.Resources.icons8_Search_16;
            this.buttonBuscar.Location = new System.Drawing.Point(572, 18);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 31);
            this.buttonBuscar.TabIndex = 52;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // cConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 443);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.Fechaspanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "cConsultas";
            this.Text = "cConsultas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Fechaspanel.ResumeLayout(false);
            this.Fechaspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox filtrarcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Fechaspanel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonBuscar;
    }
}