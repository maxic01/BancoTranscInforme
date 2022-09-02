namespace BancoTransacc
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnEditCuent = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.grillaCuenta = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCBU2 = new System.Windows.Forms.TextBox();
            this.lblCBU2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblUltimoMov = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dtpUltimoMov = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApell = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblCBU = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.txtCBUCuenta = new System.Windows.Forms.TextBox();
            this.lblCBUcuenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarClient = new System.Windows.Forms.Button();
            this.btnEliminarClient = new System.Windows.Forms.Button();
            this.btnNuevoClient = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnActualizarCuent = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarCuent = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuenta)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditCuent
            // 
            this.btnEditCuent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCuent.Location = new System.Drawing.Point(610, 209);
            this.btnEditCuent.Name = "btnEditCuent";
            this.btnEditCuent.Size = new System.Drawing.Size(126, 35);
            this.btnEditCuent.TabIndex = 113;
            this.btnEditCuent.Text = "Editar Cuenta";
            this.btnEditCuent.UseVisualStyleBackColor = true;
            this.btnEditCuent.Click += new System.EventHandler(this.btnEditCuent_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(321, 249);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(125, 35);
            this.btnEditClient.TabIndex = 112;
            this.btnEditClient.Text = "Editar Cliente";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // grillaCuenta
            // 
            this.grillaCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCuenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grillaCuenta.Location = new System.Drawing.Point(892, 6);
            this.grillaCuenta.Name = "grillaCuenta";
            this.grillaCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaCuenta.Size = new System.Drawing.Size(314, 323);
            this.grillaCuenta.TabIndex = 111;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCBU2);
            this.panel2.Controls.Add(this.lblCBU2);
            this.panel2.Controls.Add(this.lblSaldo);
            this.panel2.Controls.Add(this.txtSaldo);
            this.panel2.Controls.Add(this.lblUltimoMov);
            this.panel2.Controls.Add(this.lblTipoCuenta);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.dtpUltimoMov);
            this.panel2.Location = new System.Drawing.Point(610, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 169);
            this.panel2.TabIndex = 109;
            // 
            // txtCBU2
            // 
            this.txtCBU2.Location = new System.Drawing.Point(90, 21);
            this.txtCBU2.Name = "txtCBU2";
            this.txtCBU2.Size = new System.Drawing.Size(156, 20);
            this.txtCBU2.TabIndex = 34;
            // 
            // lblCBU2
            // 
            this.lblCBU2.AutoSize = true;
            this.lblCBU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBU2.Location = new System.Drawing.Point(26, 26);
            this.lblCBU2.Name = "lblCBU2";
            this.lblCBU2.Size = new System.Drawing.Size(35, 16);
            this.lblCBU2.TabIndex = 32;
            this.lblCBU2.Text = "CBU";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(26, 63);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(43, 16);
            this.lblSaldo.TabIndex = 35;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(90, 60);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(156, 20);
            this.txtSaldo.TabIndex = 36;
            // 
            // lblUltimoMov
            // 
            this.lblUltimoMov.AutoSize = true;
            this.lblUltimoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMov.Location = new System.Drawing.Point(7, 102);
            this.lblUltimoMov.Name = "lblUltimoMov";
            this.lblUltimoMov.Size = new System.Drawing.Size(71, 16);
            this.lblUltimoMov.TabIndex = 47;
            this.lblUltimoMov.Text = "UltimoMov";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.Location = new System.Drawing.Point(7, 136);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(80, 16);
            this.lblTipoCuenta.TabIndex = 48;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(93, 131);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(132, 21);
            this.cboTipo.TabIndex = 50;
            // 
            // dtpUltimoMov
            // 
            this.dtpUltimoMov.Location = new System.Drawing.Point(90, 96);
            this.dtpUltimoMov.Name = "dtpUltimoMov";
            this.dtpUltimoMov.Size = new System.Drawing.Size(156, 20);
            this.dtpUltimoMov.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApell);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.lblCBU);
            this.panel1.Controls.Add(this.txtCBU);
            this.panel1.Location = new System.Drawing.Point(321, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 169);
            this.panel1.TabIndex = 108;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(73, 21);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 28;
            // 
            // lblApell
            // 
            this.lblApell.AutoSize = true;
            this.lblApell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApell.Location = new System.Drawing.Point(10, 26);
            this.lblApell.Name = "lblApell";
            this.lblApell.Size = new System.Drawing.Size(57, 16);
            this.lblApell.TabIndex = 25;
            this.lblApell.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(32, 103);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 16);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(73, 99);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(155, 20);
            this.txtDNI.TabIndex = 30;
            // 
            // lblCBU
            // 
            this.lblCBU.AutoSize = true;
            this.lblCBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBU.Location = new System.Drawing.Point(32, 137);
            this.lblCBU.Name = "lblCBU";
            this.lblCBU.Size = new System.Drawing.Size(35, 16);
            this.lblCBU.TabIndex = 31;
            this.lblCBU.Text = "CBU";
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(71, 132);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(155, 20);
            this.txtCBU.TabIndex = 33;
            // 
            // txtCBUCuenta
            // 
            this.txtCBUCuenta.Location = new System.Drawing.Point(1008, 335);
            this.txtCBUCuenta.Name = "txtCBUCuenta";
            this.txtCBUCuenta.Size = new System.Drawing.Size(198, 20);
            this.txtCBUCuenta.TabIndex = 107;
            // 
            // lblCBUcuenta
            // 
            this.lblCBUcuenta.AutoSize = true;
            this.lblCBUcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBUcuenta.Location = new System.Drawing.Point(889, 339);
            this.lblCBUcuenta.Name = "lblCBUcuenta";
            this.lblCBUcuenta.Size = new System.Drawing.Size(94, 16);
            this.lblCBUcuenta.TabIndex = 106;
            this.lblCBUcuenta.Text = "CBU CUENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 105;
            this.label3.Text = "AGREGAR CUENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "AGREGAR CLIENTE";
            // 
            // btnActualizarClient
            // 
            this.btnActualizarClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClient.Location = new System.Drawing.Point(452, 251);
            this.btnActualizarClient.Name = "btnActualizarClient";
            this.btnActualizarClient.Size = new System.Drawing.Size(132, 34);
            this.btnActualizarClient.TabIndex = 103;
            this.btnActualizarClient.Text = "Actualizar Cliente";
            this.btnActualizarClient.UseVisualStyleBackColor = true;
            this.btnActualizarClient.Click += new System.EventHandler(this.btnActualizarClient_Click);
            // 
            // btnEliminarClient
            // 
            this.btnEliminarClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClient.Location = new System.Drawing.Point(321, 290);
            this.btnEliminarClient.Name = "btnEliminarClient";
            this.btnEliminarClient.Size = new System.Drawing.Size(125, 35);
            this.btnEliminarClient.TabIndex = 102;
            this.btnEliminarClient.Text = "Eliminar Cliente";
            this.btnEliminarClient.UseVisualStyleBackColor = true;
            this.btnEliminarClient.Click += new System.EventHandler(this.btnEliminarClient_Click);
            // 
            // btnNuevoClient
            // 
            this.btnNuevoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoClient.Location = new System.Drawing.Point(321, 209);
            this.btnNuevoClient.Name = "btnNuevoClient";
            this.btnNuevoClient.Size = new System.Drawing.Size(125, 35);
            this.btnNuevoClient.TabIndex = 100;
            this.btnNuevoClient.Text = "Nuevo Cliente";
            this.btnNuevoClient.UseVisualStyleBackColor = true;
            this.btnNuevoClient.Click += new System.EventHandler(this.btnNuevoClient_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(-185, 423);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(149, 36);
            this.btnOut.TabIndex = 99;
            this.btnOut.Text = "Salir";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCuent
            // 
            this.btnActualizarCuent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCuent.Location = new System.Drawing.Point(749, 209);
            this.btnActualizarCuent.Name = "btnActualizarCuent";
            this.btnActualizarCuent.Size = new System.Drawing.Size(137, 35);
            this.btnActualizarCuent.TabIndex = 97;
            this.btnActualizarCuent.Text = "Actualizar Cuenta";
            this.btnActualizarCuent.UseVisualStyleBackColor = true;
            this.btnActualizarCuent.Click += new System.EventHandler(this.btnActualizarCuent_Click);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(127, 335);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(188, 20);
            this.txtDniCliente.TabIndex = 96;
            // 
            // btnEliminarCuent
            // 
            this.btnEliminarCuent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuent.Location = new System.Drawing.Point(610, 251);
            this.btnEliminarCuent.Name = "btnEliminarCuent";
            this.btnEliminarCuent.Size = new System.Drawing.Size(126, 33);
            this.btnEliminarCuent.TabIndex = 95;
            this.btnEliminarCuent.Text = "Eliminar Cuenta";
            this.btnEliminarCuent.UseVisualStyleBackColor = true;
            this.btnEliminarCuent.Click += new System.EventHandler(this.btnEliminarCuent_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(452, 209);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(132, 35);
            this.btnAddClient.TabIndex = 94;
            this.btnAddClient.Text = "Confirmar";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(303, 323);
            this.dataGridView1.TabIndex = 93;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(892, 466);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 36);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1060, 466);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 36);
            this.btnCancelar.TabIndex = 116;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "DNI CLIENTE";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(749, 251);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(137, 33);
            this.btnInhabilitar.TabIndex = 118;
            this.btnInhabilitar.Text = "Inhabilitar Cuenta";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 514);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditCuent);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.grillaCuenta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCBUCuenta);
            this.Controls.Add(this.lblCBUcuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizarClient);
            this.Controls.Add(this.btnEliminarClient);
            this.Controls.Add(this.btnNuevoClient);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnActualizarCuent);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.btnEliminarCuent);
            this.Controls.Add(this.btnAddClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.Text = "Alta Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuenta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCuent;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.DataGridView grillaCuenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCBU2;
        private System.Windows.Forms.Label lblCBU2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblUltimoMov;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DateTimePicker dtpUltimoMov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApell;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblCBU;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.TextBox txtCBUCuenta;
        private System.Windows.Forms.Label lblCBUcuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarClient;
        private System.Windows.Forms.Button btnEliminarClient;
        private System.Windows.Forms.Button btnNuevoClient;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnActualizarCuent;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button btnEliminarCuent;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInhabilitar;
    }
}