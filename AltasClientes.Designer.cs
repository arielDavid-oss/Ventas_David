


namespace Ventas_David
{
    partial class AltasClientes
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
            lblNudCliente = new Label();
            lblEmpresa = new Label();
            lblNubRepresentante = new Label();
            lblCredito = new Label();
            nudLimCred = new NumericUpDown();
            txtNumClie = new TextBox();
            txtEmpresa = new TextBox();
            txtNumRep = new TextBox();
            btnIns = new Button();
            btnProc = new Button();
            ((System.ComponentModel.ISupportInitialize)nudLimCred).BeginInit();
            SuspendLayout();
            // 
            // lblNudCliente
            // 
            lblNudCliente.AutoSize = true;
            lblNudCliente.Location = new Point(94, 60);
            lblNudCliente.Name = "lblNudCliente";
            lblNudCliente.Size = new Size(134, 20);
            lblNudCliente.TabIndex = 0;
            lblNudCliente.Text = "Numero de Cliente";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(94, 152);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(66, 20);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "Empresa";
            // 
            // lblNubRepresentante
            // 
            lblNubRepresentante.AutoSize = true;
            lblNubRepresentante.Location = new Point(94, 232);
            lblNubRepresentante.Name = "lblNubRepresentante";
            lblNubRepresentante.Size = new Size(179, 20);
            lblNubRepresentante.TabIndex = 2;
            lblNubRepresentante.Text = "Numero de representante";
            // 
            // lblCredito
            // 
            lblCredito.AutoSize = true;
            lblCredito.Location = new Point(94, 303);
            lblCredito.Name = "lblCredito";
            lblCredito.Size = new Size(122, 20);
            lblCredito.TabIndex = 3;
            lblCredito.Text = "Limite de credito";
            // 
            // nudLimCred
            // 
            nudLimCred.Location = new Point(397, 303);
            nudLimCred.Name = "nudLimCred";
            nudLimCred.Size = new Size(107, 27);
            nudLimCred.TabIndex = 4;
            // 
            // txtNumClie
            // 
            txtNumClie.Location = new Point(397, 54);
            txtNumClie.Name = "txtNumClie";
            txtNumClie.Size = new Size(89, 27);
            txtNumClie.TabIndex = 5;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(397, 146);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(89, 27);
            txtEmpresa.TabIndex = 6;
            // 
            // txtNumRep
            // 
            txtNumRep.Location = new Point(397, 232);
            txtNumRep.Name = "txtNumRep";
            txtNumRep.Size = new Size(89, 27);
            txtNumRep.TabIndex = 7;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(98, 390);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(136, 34);
            btnIns.TabIndex = 8;
            btnIns.Text = "Guardar con Insert";
            btnIns.UseVisualStyleBackColor = true;
            // 
            // btnProc
            // 
            btnProc.Location = new Point(397, 390);
            btnProc.Name = "btnProc";
            btnProc.Size = new Size(195, 34);
            btnProc.TabIndex = 9;
            btnProc.Text = "Guardar con Procedimiento";
            btnProc.UseVisualStyleBackColor = true;
            // 
            // AltasClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(btnProc);
            Controls.Add(btnIns);
            Controls.Add(txtNumRep);
            Controls.Add(txtEmpresa);
            Controls.Add(txtNumClie);
            Controls.Add(nudLimCred);
            Controls.Add(lblCredito);
            Controls.Add(lblNubRepresentante);
            Controls.Add(lblEmpresa);
            Controls.Add(lblNudCliente);
            Name = "AltasClientes";
            Text = "FrmAltasClientes";
            Load += AltasClientes_Load;
            ((System.ComponentModel.ISupportInitialize)nudLimCred).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNudCliente;
        private Label lblEmpresa;
        private Label lblNubRepresentante;
        private Label lblCredito;
        private NumericUpDown nudLimCred;
        private TextBox txtNumClie;
        private TextBox txtEmpresa;
        private TextBox txtNumRep;
        private Button btnIns;
        private Button btnProc;
    }
}