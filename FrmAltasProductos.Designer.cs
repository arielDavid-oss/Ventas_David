namespace Ventas_David
{
    partial class FrmAltasProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIDFab = new Label();
            lblIDProd = new Label();
            lblIDes = new Label();
            lblPre = new Label();
            lblExi = new Label();
            txtIDFab = new TextBox();
            txtIDProd = new TextBox();
            txtDes = new TextBox();
            nudPre = new NumericUpDown();
            nudExi = new NumericUpDown();
            btnIns = new Button();
            btnProc = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudExi).BeginInit();
            SuspendLayout();
            // 
            // lblIDFab
            // 
            lblIDFab.AutoSize = true;
            lblIDFab.BackColor = SystemColors.ControlDark;
            lblIDFab.Location = new Point(61, 93);
            lblIDFab.Name = "lblIDFab";
            lblIDFab.Size = new Size(144, 20);
            lblIDFab.TabIndex = 0;
            lblIDFab.Text = "Clave del fabricante:";
            // 
            // lblIDProd
            // 
            lblIDProd.AutoSize = true;
            lblIDProd.BackColor = SystemColors.ControlDark;
            lblIDProd.Location = new Point(71, 141);
            lblIDProd.Name = "lblIDProd";
            lblIDProd.Size = new Size(134, 20);
            lblIDProd.TabIndex = 1;
            lblIDProd.Text = "Clave del Producto";
            // 
            // lblIDes
            // 
            lblIDes.AutoSize = true;
            lblIDes.BackColor = SystemColors.ControlDark;
            lblIDes.Location = new Point(118, 194);
            lblIDes.Name = "lblIDes";
            lblIDes.Size = new Size(87, 20);
            lblIDes.TabIndex = 2;
            lblIDes.Text = "Descripcion";
            // 
            // lblPre
            // 
            lblPre.AutoSize = true;
            lblPre.BackColor = SystemColors.ControlDark;
            lblPre.Location = new Point(155, 239);
            lblPre.Name = "lblPre";
            lblPre.Size = new Size(50, 20);
            lblPre.TabIndex = 3;
            lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            lblExi.AutoSize = true;
            lblExi.BackColor = SystemColors.AppWorkspace;
            lblExi.Location = new Point(125, 287);
            lblExi.Name = "lblExi";
            lblExi.Size = new Size(80, 20);
            lblExi.TabIndex = 4;
            lblExi.Text = "Existencias";
            // 
            // txtIDFab
            // 
            txtIDFab.Location = new Point(249, 86);
            txtIDFab.Name = "txtIDFab";
            txtIDFab.Size = new Size(125, 27);
            txtIDFab.TabIndex = 5;
            // 
            // txtIDProd
            // 
            txtIDProd.Location = new Point(249, 141);
            txtIDProd.Name = "txtIDProd";
            txtIDProd.Size = new Size(125, 27);
            txtIDProd.TabIndex = 6;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(249, 191);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(361, 27);
            txtDes.TabIndex = 7;
            // 
            // nudPre
            // 
            nudPre.DecimalPlaces = 2;
            nudPre.Location = new Point(249, 239);
            nudPre.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPre.Name = "nudPre";
            nudPre.Size = new Size(150, 27);
            nudPre.TabIndex = 8;
            nudPre.ValueChanged += nudPre_ValueChanged;
            // 
            // nudExi
            // 
            nudExi.Location = new Point(249, 287);
            nudExi.Name = "nudExi";
            nudExi.Size = new Size(150, 27);
            nudExi.TabIndex = 9;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(155, 379);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(196, 29);
            btnIns.TabIndex = 10;
            btnIns.Text = "Guardar con Insert";
            btnIns.UseVisualStyleBackColor = true;
            btnIns.Click += button1_Click;
            // 
            // btnProc
            // 
            btnProc.Location = new Point(417, 379);
            btnProc.Name = "btnProc";
            btnProc.Size = new Size(243, 29);
            btnProc.TabIndex = 11;
            btnProc.Text = "Guardar con Procedimiento";
            btnProc.UseVisualStyleBackColor = true;
            btnProc.Click += btnProc_Click;
            // 
            // FrmAltasProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProc);
            Controls.Add(btnIns);
            Controls.Add(nudExi);
            Controls.Add(nudPre);
            Controls.Add(txtDes);
            Controls.Add(txtIDProd);
            Controls.Add(txtIDFab);
            Controls.Add(lblExi);
            Controls.Add(lblPre);
            Controls.Add(lblIDes);
            Controls.Add(lblIDProd);
            Controls.Add(lblIDFab);
            Name = "FrmAltasProductos";
            Text = "Inventario de productos";
            Load += FrmAltasProductos_Load;
            ((System.ComponentModel.ISupportInitialize)nudPre).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudExi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDFab;
        private Label lblIDProd;
        private Label lblIDes;
        private Label lblPre;
        private Label lblExi;
        private TextBox txtIDFab;
        private TextBox txtIDProd;
        private TextBox txtDes;
        private NumericUpDown nudPre;
        private NumericUpDown nudExi;
        private Button btnIns;
        private Button btnProc;
    }
}