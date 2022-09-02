namespace BancoTransacc.presentacion
{
    partial class frmCuentasDeshab
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
            this.grillaDeshab = new System.Windows.Forms.DataGridView();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.lblCBUcuenta = new System.Windows.Forms.Label();
            this.txtCBUCuenta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeshab)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDeshab
            // 
            this.grillaDeshab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeshab.Location = new System.Drawing.Point(412, 24);
            this.grillaDeshab.Name = "grillaDeshab";
            this.grillaDeshab.Size = new System.Drawing.Size(295, 288);
            this.grillaDeshab.TabIndex = 0;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Location = new System.Drawing.Point(195, 24);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(196, 32);
            this.btnHabilitar.TabIndex = 120;
            this.btnHabilitar.Text = "Habilitar Cuenta";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // lblCBUcuenta
            // 
            this.lblCBUcuenta.AutoSize = true;
            this.lblCBUcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBUcuenta.Location = new System.Drawing.Point(409, 329);
            this.lblCBUcuenta.Name = "lblCBUcuenta";
            this.lblCBUcuenta.Size = new System.Drawing.Size(94, 16);
            this.lblCBUcuenta.TabIndex = 121;
            this.lblCBUcuenta.Text = "CBU CUENTA";
            // 
            // txtCBUCuenta
            // 
            this.txtCBUCuenta.Location = new System.Drawing.Point(509, 325);
            this.txtCBUCuenta.Name = "txtCBUCuenta";
            this.txtCBUCuenta.Size = new System.Drawing.Size(198, 20);
            this.txtCBUCuenta.TabIndex = 122;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(458, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 36);
            this.btnSalir.TabIndex = 124;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(626, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 36);
            this.btnCancelar.TabIndex = 123;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCuentasDeshab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCBUCuenta);
            this.Controls.Add(this.lblCBUcuenta);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.grillaDeshab);
            this.Name = "frmCuentasDeshab";
            this.Text = "frmCuentasDeshab";
            this.Load += new System.EventHandler(this.frmCuentasDeshab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeshab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDeshab;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Label lblCBUcuenta;
        private System.Windows.Forms.TextBox txtCBUCuenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
    }
}