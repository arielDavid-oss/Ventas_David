namespace Ventas_David
{
    partial class frmDescontinuarProd
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
            lblIDFab = new Label();
            lblIDProd = new Label();
            lblIDes = new Label();
            lblPre = new Label();
            lblExi = new Label();
            cmbIDFab = new ComboBox();
            cmbIDProd = new ComboBox();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblSta = new Label();
            lblStatus = new Label();
            btnDescontinuar = new Button();
            SuspendLayout();
            // 
            // lblIDFab
            // 
            lblIDFab.AutoSize = true;
            lblIDFab.Location = new Point(129, 80);
            lblIDFab.Name = "lblIDFab";
            lblIDFab.Size = new Size(141, 20);
            lblIDFab.TabIndex = 0;
            lblIDFab.Text = "Clave del fabricante";
            // 
            // lblIDProd
            // 
            lblIDProd.AutoSize = true;
            lblIDProd.Location = new Point(129, 147);
            lblIDProd.Name = "lblIDProd";
            lblIDProd.Size = new Size(135, 20);
            lblIDProd.TabIndex = 1;
            lblIDProd.Text = "Clave del producto";
            // 
            // lblIDes
            // 
            lblIDes.AutoSize = true;
            lblIDes.Location = new Point(129, 210);
            lblIDes.Name = "lblIDes";
            lblIDes.Size = new Size(87, 20);
            lblIDes.TabIndex = 2;
            lblIDes.Text = "Descripcion";
            // 
            // lblPre
            // 
            lblPre.AutoSize = true;
            lblPre.Location = new Point(129, 270);
            lblPre.Name = "lblPre";
            lblPre.Size = new Size(50, 20);
            lblPre.TabIndex = 3;
            lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            lblExi.AutoSize = true;
            lblExi.Location = new Point(129, 318);
            lblExi.Name = "lblExi";
            lblExi.Size = new Size(80, 20);
            lblExi.TabIndex = 4;
            lblExi.Text = "Existencias";
            // 
            // cmbIDFab
            // 
            cmbIDFab.FormattingEnabled = true;
            cmbIDFab.Location = new Point(353, 82);
            cmbIDFab.Name = "cmbIDFab";
            cmbIDFab.Size = new Size(211, 28);
            cmbIDFab.TabIndex = 5;
            cmbIDFab.SelectedIndexChanged += cmbIDFab_SelectedIndexChanged;
            // 
            // cmbIDProd
            // 
            cmbIDProd.FormattingEnabled = true;
            cmbIDProd.Location = new Point(353, 148);
            cmbIDProd.Name = "cmbIDProd";
            cmbIDProd.Size = new Size(211, 28);
            cmbIDProd.TabIndex = 6;
            cmbIDProd.SelectedIndexChanged += cmbIDProd_SelectedIndexChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(353, 210);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(28, 28);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "””";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(353, 270);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(28, 28);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "””";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(353, 318);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(28, 28);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "””";
            // 
            // lblSta
            // 
            lblSta.AutoSize = true;
            lblSta.Location = new Point(129, 373);
            lblSta.Name = "lblSta";
            lblSta.Size = new Size(147, 20);
            lblSta.TabIndex = 10;
            lblSta.Text = " Estado del Producto";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(353, 373);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(21, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "\"\"";
            // 
            // btnDescontinuar
            // 
            btnDescontinuar.Location = new Point(568, 390);
            btnDescontinuar.Name = "btnDescontinuar";
            btnDescontinuar.Size = new Size(200, 29);
            btnDescontinuar.TabIndex = 12;
            btnDescontinuar.Text = "Descontinuar";
            btnDescontinuar.UseVisualStyleBackColor = true;
            btnDescontinuar.Click += btnDescontinuar_Click;
            // 
            // frmDescontinuarProd
            // 
            AccessibleName = "descontinuar";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDescontinuar);
            Controls.Add(lblStatus);
            Controls.Add(lblSta);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(cmbIDProd);
            Controls.Add(cmbIDFab);
            Controls.Add(lblExi);
            Controls.Add(lblPre);
            Controls.Add(lblIDes);
            Controls.Add(lblIDProd);
            Controls.Add(lblIDFab);
            Name = "frmDescontinuarProd";
            Text = "Descontinuar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDFab;
        private Label lblIDProd;
        private Label lblIDes;
        private Label lblPre;
        private Label lblExi;
        private ComboBox cmbIDFab;
        private ComboBox cmbIDProd;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblSta;
        private Label lblStatus;
        private Button btnDescontinuar;
    }
}