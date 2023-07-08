namespace Ventas_David
{
    partial class FrmActualizarProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbIDFab = new ComboBox();
            cmbIDProd = new ComboBox();
            txtDes = new TextBox();
            nudPre = new NumericUpDown();
            nudExi = new NumericUpDown();
            lblStatus = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudExi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 88);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Clave del Fabricante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 139);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Clave del Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 187);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 238);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 289);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 340);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // cmbIDFab
            // 
            cmbIDFab.FormattingEnabled = true;
            cmbIDFab.Location = new Point(318, 80);
            cmbIDFab.Name = "cmbIDFab";
            cmbIDFab.Size = new Size(151, 28);
            cmbIDFab.TabIndex = 6;
            cmbIDFab.SelectedIndexChanged += cmbIDFab_SelectedIndexChanged;
            // 
            // cmbIDProd
            // 
            cmbIDProd.FormattingEnabled = true;
            cmbIDProd.Location = new Point(318, 136);
            cmbIDProd.Name = "cmbIDProd";
            cmbIDProd.Size = new Size(151, 28);
            cmbIDProd.TabIndex = 7;
            cmbIDProd.SelectedIndexChanged += cmbIDProd_SelectedIndexChanged;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(289, 184);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(203, 27);
            txtDes.TabIndex = 8;
            txtDes.TextChanged += txtDes_TextChanged;
            // 
            // nudPre
            // 
            nudPre.DecimalPlaces = 2;
            nudPre.Location = new Point(318, 231);
            nudPre.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPre.Name = "nudPre";
            nudPre.Size = new Size(150, 27);
            nudPre.TabIndex = 9;
            // 
            // nudExi
            // 
            nudExi.Location = new Point(318, 282);
            nudExi.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudExi.Name = "nudExi";
            nudExi.Size = new Size(150, 27);
            nudExi.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(318, 340);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(21, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "\"\"";
            // 
            // button1
            // 
            button1.Location = new Point(292, 386);
            button1.Name = "button1";
            button1.Size = new Size(200, 29);
            button1.TabIndex = 12;
            button1.Text = "Actualizar Registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnActualizar_Click;
            // 
            // FrmActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Controls.Add(nudExi);
            Controls.Add(nudPre);
            Controls.Add(txtDes);
            Controls.Add(cmbIDProd);
            Controls.Add(cmbIDFab);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmActualizarProducto";
            Text = "Actualizar Producto";
            Load += FrmActualizarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPre).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudExi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbIDFab;
        private ComboBox cmbIDProd;
        private TextBox txtDes;
        private NumericUpDown nudPre;
        private NumericUpDown nudExi;
        private Label lblStatus;
        private Button button1;
    }
}