namespace Puesto
{
    partial class FormModificar
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombreProductoModificar = new System.Windows.Forms.TextBox();
            this.txtNuevoNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNuevoTamañoProducto = new System.Windows.Forms.TextBox();
            this.txtNuevoPrecioProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(123, 63);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(570, 150);
            this.dataGridViewProductos.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(330, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 29);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombreProductoModificar
            // 
            this.txtNombreProductoModificar.Location = new System.Drawing.Point(317, 261);
            this.txtNombreProductoModificar.Name = "txtNombreProductoModificar";
            this.txtNombreProductoModificar.Size = new System.Drawing.Size(192, 20);
            this.txtNombreProductoModificar.TabIndex = 2;
            // 
            // txtNuevoNombreProducto
            // 
            this.txtNuevoNombreProducto.Location = new System.Drawing.Point(43, 323);
            this.txtNuevoNombreProducto.Name = "txtNuevoNombreProducto";
            this.txtNuevoNombreProducto.Size = new System.Drawing.Size(136, 20);
            this.txtNuevoNombreProducto.TabIndex = 3;
            // 
            // txtNuevoTamañoProducto
            // 
            this.txtNuevoTamañoProducto.Location = new System.Drawing.Point(303, 323);
            this.txtNuevoTamañoProducto.Name = "txtNuevoTamañoProducto";
            this.txtNuevoTamañoProducto.Size = new System.Drawing.Size(114, 20);
            this.txtNuevoTamañoProducto.TabIndex = 4;
            // 
            // txtNuevoPrecioProducto
            // 
            this.txtNuevoPrecioProducto.Location = new System.Drawing.Point(504, 323);
            this.txtNuevoPrecioProducto.Name = "txtNuevoPrecioProducto";
            this.txtNuevoPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoPrecioProducto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Producto a Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevo nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "MODIFICAR PRODUCTOS";
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuevoPrecioProducto);
            this.Controls.Add(this.txtNuevoTamañoProducto);
            this.Controls.Add(this.txtNuevoNombreProducto);
            this.Controls.Add(this.txtNombreProductoModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FormModificar";
            this.Text = "FormModificar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombreProductoModificar;
        private System.Windows.Forms.TextBox txtNuevoNombreProducto;
        private System.Windows.Forms.TextBox txtNuevoTamañoProducto;
        private System.Windows.Forms.TextBox txtNuevoPrecioProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}