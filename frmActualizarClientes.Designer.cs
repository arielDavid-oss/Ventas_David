namespace Ventas_David
{
    partial class frmActualizarClientes
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
            lbel1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comNumCli = new ComboBox();
            numLimiCre = new NumericUpDown();
            txtEmpresa = new TextBox();
            StatusCli = new Label();
            btnActualizar = new Button();
            txtNumRep = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numLimiCre).BeginInit();
            SuspendLayout();
            // 
            // lbel1
            // 
            lbel1.AutoSize = true;
            lbel1.Location = new Point(109, 50);
            lbel1.Name = "lbel1";
            lbel1.Size = new Size(132, 20);
            lbel1.TabIndex = 0;
            lbel1.Text = "Numero de cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 172);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 110);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 2;
            label3.Text = "Numero de representante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 217);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Limite de credito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 281);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // comNumCli
            // 
            comNumCli.FormattingEnabled = true;
            comNumCli.Location = new Point(356, 41);
            comNumCli.Name = "comNumCli";
            comNumCli.Size = new Size(157, 28);
            comNumCli.TabIndex = 5;
            comNumCli.SelectedIndexChanged += comNumCli_SelectedIndexChanged;
            // 
            // numLimiCre
            // 
            numLimiCre.Location = new Point(356, 217);
            numLimiCre.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numLimiCre.Name = "numLimiCre";
            numLimiCre.Size = new Size(198, 27);
            numLimiCre.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(352, 169);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(309, 27);
            txtEmpresa.TabIndex = 9;
            // 
            // StatusCli
            // 
            StatusCli.AutoSize = true;
            StatusCli.Location = new Point(352, 281);
            StatusCli.Name = "StatusCli";
            StatusCli.Size = new Size(21, 20);
            StatusCli.TabIndex = 11;
            StatusCli.Text = "\"\"";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(299, 361);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 36);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtNumRep
            // 
            txtNumRep.FormattingEnabled = true;
            txtNumRep.Location = new Point(352, 102);
            txtNumRep.Name = "txtNumRep";
            txtNumRep.Size = new Size(161, 28);
            txtNumRep.TabIndex = 13;
            txtNumRep.SelectedIndexChanged += txtNumRep_SelectedIndexChanged;
            // 
            // frmActualizarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(txtNumRep);
            Controls.Add(btnActualizar);
            Controls.Add(StatusCli);
            Controls.Add(txtEmpresa);
            Controls.Add(numLimiCre);
            Controls.Add(comNumCli);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbel1);
            Name = "frmActualizarClientes";
            Text = "frmActualizarClie";
            Load += frmActualizarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)numLimiCre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comNumCli;
        private NumericUpDown numLimiCre;
        private TextBox txtEmpresa;
        private Label StatusCli;
        private Button btnActualizar;
        private ComboBox txtNumRep;
    }
}