namespace Ventas_David
{
    partial class frmDescontinuarClientes
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
            lblNumClie = new Label();
            lblEmpresa = new Label();
            lblNumPep = new Label();
            lblLimCred = new Label();
            comboBox1 = new ComboBox();
            btnDescontinuar = new Button();
            lblEmp = new Label();
            label2 = new Label();
            label3 = new Label();
            lblEstado = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblNumClie
            // 
            lblNumClie.AutoSize = true;
            lblNumClie.Location = new Point(148, 62);
            lblNumClie.Name = "lblNumClie";
            lblNumClie.Size = new Size(132, 20);
            lblNumClie.TabIndex = 0;
            lblNumClie.Text = "Numero de cliente";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(148, 129);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(66, 20);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "Empresa";
            // 
            // lblNumPep
            // 
            lblNumPep.AutoSize = true;
            lblNumPep.Location = new Point(148, 196);
            lblNumPep.Name = "lblNumPep";
            lblNumPep.Size = new Size(183, 20);
            lblNumPep.TabIndex = 2;
            lblNumPep.Text = "Numero de Representante";
            // 
            // lblLimCred
            // 
            lblLimCred.AutoSize = true;
            lblLimCred.Location = new Point(148, 258);
            lblLimCred.Name = "lblLimCred";
            lblLimCred.Size = new Size(124, 20);
            lblLimCred.TabIndex = 3;
            lblLimCred.Text = "Limite de Credito";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(367, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 28);
            comboBox1.TabIndex = 4;
            // 
            // btnDescontinuar
            // 
            btnDescontinuar.Location = new Point(335, 374);
            btnDescontinuar.Name = "btnDescontinuar";
            btnDescontinuar.Size = new Size(140, 29);
            btnDescontinuar.TabIndex = 5;
            btnDescontinuar.Text = "Descontinuar";
            btnDescontinuar.UseVisualStyleBackColor = true;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Location = new Point(364, 129);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(21, 20);
            lblEmp.TabIndex = 6;
            lblEmp.Text = "\"\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 258);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 7;
            label2.Text = "\"\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 190);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 8;
            label3.Text = "\"\"";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(148, 315);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 315);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 10;
            label4.Text = "\"\"";
            // 
            // frmDescontinuarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(label4);
            Controls.Add(lblEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblEmp);
            Controls.Add(btnDescontinuar);
            Controls.Add(comboBox1);
            Controls.Add(lblLimCred);
            Controls.Add(lblNumPep);
            Controls.Add(lblEmpresa);
            Controls.Add(lblNumClie);
            Name = "frmDescontinuarClientes";
            Text = "frmDescontinuarClie";
            Load += frmDescontinuarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumClie;
        private Label lblEmpresa;
        private Label lblNumPep;
        private Label lblLimCred;
        private ComboBox comboBox1;
        private Button btnDescontinuar;
        private Label lblEmp;
        private Label label2;
        private Label label3;
        private Label lblEstado;
        private Label label4;
    }
}