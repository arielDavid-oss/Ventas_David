namespace Ventas_David
{
    partial class frmEliminar
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
            btnDescontinuar = new Button();
            lblStatus = new Label();
            lblSta = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            cmbIDProd = new ComboBox();
            cmbIDFab = new ComboBox();
            lblExi = new Label();
            lblPre = new Label();
            lblIDes = new Label();
            lblIDProd = new Label();
            lblIDFab = new Label();
            SuspendLayout();
            // 
            // btnDescontinuar
            // 
            btnDescontinuar.Location = new Point(520, 366);
            btnDescontinuar.Name = "btnDescontinuar";
            btnDescontinuar.Size = new Size(200, 29);
            btnDescontinuar.TabIndex = 25;
            btnDescontinuar.Text = "Eliminar";
            btnDescontinuar.UseVisualStyleBackColor = true;
            btnDescontinuar.Click += btnDescontinuar_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(305, 349);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(21, 20);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "\"\"";
            // 
            // lblSta
            // 
            lblSta.AutoSize = true;
            lblSta.Location = new Point(81, 349);
            lblSta.Name = "lblSta";
            lblSta.Size = new Size(147, 20);
            lblSta.TabIndex = 23;
            lblSta.Text = " Estado del Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(305, 294);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(28, 28);
            lblCantidad.TabIndex = 22;
            lblCantidad.Text = "””";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(305, 246);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(28, 28);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "””";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(305, 186);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(28, 28);
            lblDescripcion.TabIndex = 20;
            lblDescripcion.Text = "””";
            // 
            // cmbIDProd
            // 
            cmbIDProd.FormattingEnabled = true;
            cmbIDProd.Location = new Point(305, 124);
            cmbIDProd.Name = "cmbIDProd";
            cmbIDProd.Size = new Size(211, 28);
            cmbIDProd.TabIndex = 19;
            cmbIDProd.SelectedIndexChanged += cmbIDProd_SelectedIndexChanged;
            // 
            // cmbIDFab
            // 
            cmbIDFab.FormattingEnabled = true;
            cmbIDFab.Location = new Point(305, 58);
            cmbIDFab.Name = "cmbIDFab";
            cmbIDFab.Size = new Size(211, 28);
            cmbIDFab.TabIndex = 18;
            cmbIDFab.SelectedIndexChanged += cmbIDFab_SelectedIndexChanged;
            // 
            // lblExi
            // 
            lblExi.AutoSize = true;
            lblExi.Location = new Point(81, 294);
            lblExi.Name = "lblExi";
            lblExi.Size = new Size(80, 20);
            lblExi.TabIndex = 17;
            lblExi.Text = "Existencias";
            // 
            // lblPre
            // 
            lblPre.AutoSize = true;
            lblPre.Location = new Point(81, 246);
            lblPre.Name = "lblPre";
            lblPre.Size = new Size(50, 20);
            lblPre.TabIndex = 16;
            lblPre.Text = "Precio";
            // 
            // lblIDes
            // 
            lblIDes.AutoSize = true;
            lblIDes.Location = new Point(81, 186);
            lblIDes.Name = "lblIDes";
            lblIDes.Size = new Size(87, 20);
            lblIDes.TabIndex = 15;
            lblIDes.Text = "Descripcion";
            // 
            // lblIDProd
            // 
            lblIDProd.AutoSize = true;
            lblIDProd.Location = new Point(81, 123);
            lblIDProd.Name = "lblIDProd";
            lblIDProd.Size = new Size(135, 20);
            lblIDProd.TabIndex = 14;
            lblIDProd.Text = "Clave del producto";
            // 
            // lblIDFab
            // 
            lblIDFab.AutoSize = true;
            lblIDFab.Location = new Point(81, 56);
            lblIDFab.Name = "lblIDFab";
            lblIDFab.Size = new Size(141, 20);
            lblIDFab.TabIndex = 13;
            lblIDFab.Text = "Clave del fabricante";
            // 
            // frmEliminar
            // 
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
            Name = "frmEliminar";
            Text = "frmEliminar";
            Load += frmEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDescontinuar;
        private Label lblStatus;
        private Label lblSta;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblDescripcion;
        private ComboBox cmbIDProd;
        private ComboBox cmbIDFab;
        private Label lblExi;
        private Label lblPre;
        private Label lblIDes;
        private Label lblIDProd;
        private Label lblIDFab;
    }
}