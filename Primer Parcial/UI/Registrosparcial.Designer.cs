namespace Primer_Parcial.UI
{
    partial class Registrosparcial
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.SueldonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RetencionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RetecnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetecnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 17);
            this.label.TabIndex = 4;
            this.label.Text = "VendedorID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "%Retencion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Retencion";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(156, 79);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(235, 22);
            this.IDnumericUpDown.TabIndex = 10;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(156, 132);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(338, 22);
            this.NombretextBox.TabIndex = 11;
            // 
            // SueldonumericUpDown
            // 
            this.SueldonumericUpDown.DecimalPlaces = 2;
            this.SueldonumericUpDown.Location = new System.Drawing.Point(156, 179);
            this.SueldonumericUpDown.Name = "SueldonumericUpDown";
            this.SueldonumericUpDown.Size = new System.Drawing.Size(106, 22);
            this.SueldonumericUpDown.TabIndex = 12;
            this.SueldonumericUpDown.ValueChanged += new System.EventHandler(this.SueldonumericUpDown_ValueChanged);
            // 
            // RetencionnumericUpDown
            // 
            this.RetencionnumericUpDown.DecimalPlaces = 2;
            this.RetencionnumericUpDown.Location = new System.Drawing.Point(374, 179);
            this.RetencionnumericUpDown.Name = "RetencionnumericUpDown";
            this.RetencionnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.RetencionnumericUpDown.TabIndex = 13;
            this.RetencionnumericUpDown.ValueChanged += new System.EventHandler(this.RetencionnumericUpDown_ValueChanged);
            // 
            // RetecnumericUpDown
            // 
            this.RetecnumericUpDown.DecimalPlaces = 2;
            this.RetecnumericUpDown.Location = new System.Drawing.Point(156, 229);
            this.RetecnumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RetecnumericUpDown.Name = "RetecnumericUpDown";
            this.RetecnumericUpDown.ReadOnly = true;
            this.RetecnumericUpDown.Size = new System.Drawing.Size(338, 22);
            this.RetecnumericUpDown.TabIndex = 14;
            this.RetecnumericUpDown.ValueChanged += new System.EventHandler(this.RetecnumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha Vendedor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Primer_Parcial.Properties.Resources.Eliminar;
            this.Eliminarbutton.Location = new System.Drawing.Point(400, 309);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 76);
            this.Eliminarbutton.TabIndex = 3;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Primer_Parcial.Properties.Resources.icons8_guardar_48;
            this.Guardarbutton.Location = new System.Drawing.Point(261, 309);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(95, 76);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Primer_Parcial.Properties.Resources.icons8_nuevo_48;
            this.Nuevobutton.Location = new System.Drawing.Point(121, 309);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(82, 76);
            this.Nuevobutton.TabIndex = 1;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Primer_Parcial.Properties.Resources.Buscar;
            this.Buscarbutton.Location = new System.Drawing.Point(404, 59);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(90, 60);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(156, 270);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(338, 22);
            this.FechadateTimePicker.TabIndex = 16;
            this.FechadateTimePicker.ValueChanged += new System.EventHandler(this.FechadateTimePicker1_ValueChanged);
            // 
            // Registrosparcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RetecnumericUpDown);
            this.Controls.Add(this.RetencionnumericUpDown);
            this.Controls.Add(this.SueldonumericUpDown);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "Registrosparcial";
            this.Text = "Registros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetecnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown RetencionnumericUpDown;
        private System.Windows.Forms.NumericUpDown SueldonumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RetecnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
    }
}