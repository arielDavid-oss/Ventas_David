namespace Ventas_David
{
    partial class FrmQueryProductos
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
            groupBox1 = new GroupBox();
            txtProdExi = new TextBox();
            cmbOperadores = new ComboBox();
            comFab = new ComboBox();
            rbtnProdFab = new RadioButton();
            rbtnProdConExi = new RadioButton();
            rbtnListaProd = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cmbInvProv = new ComboBox();
            rbtnEdoProd = new RadioButton();
            rbtnTotInvProv = new RadioButton();
            rbtnTotInv = new RadioButton();
            btnMostrar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProdExi);
            groupBox1.Controls.Add(cmbOperadores);
            groupBox1.Controls.Add(comFab);
            groupBox1.Controls.Add(rbtnProdFab);
            groupBox1.Controls.Add(rbtnProdConExi);
            groupBox1.Controls.Add(rbtnListaProd);
            groupBox1.Location = new Point(35, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // txtProdExi
            // 
            txtProdExi.Location = new Point(346, 130);
            txtProdExi.Name = "txtProdExi";
            txtProdExi.Size = new Size(142, 27);
            txtProdExi.TabIndex = 7;
            // 
            // cmbOperadores
            // 
            cmbOperadores.FormattingEnabled = true;
            cmbOperadores.Location = new Point(213, 129);
            cmbOperadores.Name = "cmbOperadores";
            cmbOperadores.Size = new Size(83, 28);
            cmbOperadores.TabIndex = 6;
            // 
            // comFab
            // 
            comFab.FormattingEnabled = true;
            comFab.Location = new Point(302, 84);
            comFab.Name = "comFab";
            comFab.Size = new Size(194, 28);
            comFab.TabIndex = 5;
            comFab.SelectedIndexChanged += comFab_SelectedIndexChanged;
            // 
            // rbtnProdFab
            // 
            rbtnProdFab.AutoSize = true;
            rbtnProdFab.Location = new Point(6, 84);
            rbtnProdFab.Name = "rbtnProdFab";
            rbtnProdFab.Size = new Size(290, 24);
            rbtnProdFab.TabIndex = 1;
            rbtnProdFab.TabStop = true;
            rbtnProdFab.Text = "Productos que pertenecen al fabricante";
            rbtnProdFab.UseVisualStyleBackColor = true;
            // 
            // rbtnProdConExi
            // 
            rbtnProdConExi.AutoSize = true;
            rbtnProdConExi.Location = new Point(6, 128);
            rbtnProdConExi.Name = "rbtnProdConExi";
            rbtnProdConExi.Size = new Size(193, 24);
            rbtnProdConExi.TabIndex = 4;
            rbtnProdConExi.TabStop = true;
            rbtnProdConExi.Text = "Productos con existencia";
            rbtnProdConExi.UseVisualStyleBackColor = true;
            // 
            // rbtnListaProd
            // 
            rbtnListaProd.AutoSize = true;
            rbtnListaProd.Location = new Point(6, 43);
            rbtnListaProd.Name = "rbtnListaProd";
            rbtnListaProd.Size = new Size(169, 24);
            rbtnListaProd.TabIndex = 0;
            rbtnListaProd.TabStop = true;
            rbtnListaProd.Text = "Listado de Productos";
            rbtnListaProd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 38);
            label1.TabIndex = 1;
            label1.Text = "Consulta de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 67);
            label2.Name = "label2";
            label2.Size = new Size(439, 20);
            label2.TabIndex = 2;
            label2.Text = "Elige una opcion y luego preciona \"Mostrar\" para ver la consulta ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbInvProv);
            groupBox2.Controls.Add(rbtnEdoProd);
            groupBox2.Controls.Add(rbtnTotInvProv);
            groupBox2.Controls.Add(rbtnTotInv);
            groupBox2.Location = new Point(573, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inventario de Productos";
            // 
            // cmbInvProv
            // 
            cmbInvProv.FormattingEnabled = true;
            cmbInvProv.Location = new Point(270, 78);
            cmbInvProv.Name = "cmbInvProv";
            cmbInvProv.Size = new Size(151, 28);
            cmbInvProv.TabIndex = 6;
            // 
            // rbtnEdoProd
            // 
            rbtnEdoProd.AutoSize = true;
            rbtnEdoProd.Location = new Point(6, 122);
            rbtnEdoProd.Name = "rbtnEdoProd";
            rbtnEdoProd.Size = new Size(190, 24);
            rbtnEdoProd.TabIndex = 5;
            rbtnEdoProd.TabStop = true;
            rbtnEdoProd.Text = "Estado de los productos";
            rbtnEdoProd.UseVisualStyleBackColor = true;
            // 
            // rbtnTotInvProv
            // 
            rbtnTotInvProv.AutoSize = true;
            rbtnTotInvProv.Location = new Point(6, 78);
            rbtnTotInvProv.Name = "rbtnTotInvProv";
            rbtnTotInvProv.Size = new Size(258, 24);
            rbtnTotInvProv.TabIndex = 1;
            rbtnTotInvProv.TabStop = true;
            rbtnTotInvProv.Text = "Total del inventario por proveedor";
            rbtnTotInvProv.UseVisualStyleBackColor = true;
            // 
            // rbtnTotInv
            // 
            rbtnTotInv.AutoSize = true;
            rbtnTotInv.Location = new Point(6, 37);
            rbtnTotInv.Name = "rbtnTotInv";
            rbtnTotInv.Size = new Size(158, 24);
            rbtnTotInv.TabIndex = 0;
            rbtnTotInv.TabStop = true;
            rbtnTotInv.Text = "Total del inventario";
            rbtnTotInv.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(372, 316);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(287, 34);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 375);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(979, 332);
            dataGridView1.TabIndex = 5;
            // 
            // FrmQueryProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 737);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrar);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmQueryProductos";
            Text = "Consulta de Productos";
            Load += FrmQueryProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rbtnTotInvProv;
        private RadioButton rbtnTotInv;
        private RadioButton rbtnListaProd;
        private RadioButton rbtnProdFab;
        private RadioButton rbtnProdConExi;
        private RadioButton rbtnEdoProd;
        private TextBox txtProdExi;
        private ComboBox cmbOperadores;
        private ComboBox comFab;
        private ComboBox cmbInvProv;
        private Button btnMostrar;
        private DataGridView dataGridView1;
    }
}