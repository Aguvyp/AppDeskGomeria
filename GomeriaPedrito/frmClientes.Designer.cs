namespace GomeriaPedrito
{
    partial class frmClientes
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarCli = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListCliente = new System.Windows.Forms.DataGridView();
            this.btnCleanSearch = new System.Windows.Forms.Button();
            this.btnNewCli = new System.Windows.Forms.Button();
            this.gbxClienteNew = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbxDatosEdit = new System.Windows.Forms.GroupBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.txtVehiculoEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonoEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrabajoEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocalidadEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnCancelNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCliente)).BeginInit();
            this.gbxClienteNew.SuspendLayout();
            this.gbxDatosEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 31);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBuscar.Size = new System.Drawing.Size(156, 26);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "BUSCAR CLIENTE";
            // 
            // txtBuscarCli
            // 
            this.txtBuscarCli.Location = new System.Drawing.Point(12, 60);
            this.txtBuscarCli.Name = "txtBuscarCli";
            this.txtBuscarCli.Size = new System.Drawing.Size(197, 20);
            this.txtBuscarCli.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.Location = new System.Drawing.Point(215, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListCliente
            // 
            this.dgvListCliente.AllowUserToResizeColumns = false;
            this.dgvListCliente.AllowUserToResizeRows = false;
            this.dgvListCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCliente.Location = new System.Drawing.Point(12, 100);
            this.dgvListCliente.Name = "dgvListCliente";
            this.dgvListCliente.ReadOnly = true;
            this.dgvListCliente.Size = new System.Drawing.Size(960, 173);
            this.dgvListCliente.TabIndex = 3;
            this.dgvListCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCliente_CellClick);
            // 
            // btnCleanSearch
            // 
            this.btnCleanSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCleanSearch.Location = new System.Drawing.Point(312, 54);
            this.btnCleanSearch.Name = "btnCleanSearch";
            this.btnCleanSearch.Size = new System.Drawing.Size(112, 26);
            this.btnCleanSearch.TabIndex = 4;
            this.btnCleanSearch.Text = "Limpiar busqueda";
            this.btnCleanSearch.UseVisualStyleBackColor = false;
            this.btnCleanSearch.Click += new System.EventHandler(this.btnCleanSearch_Click);
            // 
            // btnNewCli
            // 
            this.btnNewCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCli.BackColor = System.Drawing.Color.Aqua;
            this.btnNewCli.Location = new System.Drawing.Point(839, 31);
            this.btnNewCli.Name = "btnNewCli";
            this.btnNewCli.Size = new System.Drawing.Size(112, 51);
            this.btnNewCli.TabIndex = 5;
            this.btnNewCli.Text = "Cliente nuevo";
            this.btnNewCli.UseVisualStyleBackColor = false;
            this.btnNewCli.Click += new System.EventHandler(this.btnNewCli_Click);
            // 
            // gbxClienteNew
            // 
            this.gbxClienteNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxClienteNew.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gbxClienteNew.Controls.Add(this.btnCancelNew);
            this.gbxClienteNew.Controls.Add(this.btnSave);
            this.gbxClienteNew.Controls.Add(this.txtCar);
            this.gbxClienteNew.Controls.Add(this.label5);
            this.gbxClienteNew.Controls.Add(this.txtTel);
            this.gbxClienteNew.Controls.Add(this.label4);
            this.gbxClienteNew.Controls.Add(this.txtJob);
            this.gbxClienteNew.Controls.Add(this.label3);
            this.gbxClienteNew.Controls.Add(this.txtLocalidad);
            this.gbxClienteNew.Controls.Add(this.lab);
            this.gbxClienteNew.Controls.Add(this.txtName);
            this.gbxClienteNew.Controls.Add(this.label1);
            this.gbxClienteNew.Enabled = false;
            this.gbxClienteNew.Location = new System.Drawing.Point(12, 466);
            this.gbxClienteNew.Name = "gbxClienteNew";
            this.gbxClienteNew.Size = new System.Drawing.Size(960, 128);
            this.gbxClienteNew.TabIndex = 6;
            this.gbxClienteNew.TabStop = false;
            this.gbxClienteNew.Text = "Datos del cliente nuevo";
            this.gbxClienteNew.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Location = new System.Drawing.Point(777, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(284, 62);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(123, 20);
            this.txtCar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vehículo:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(62, 62);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(123, 20);
            this.txtTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(449, 45);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(293, 37);
            this.txtJob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trabajo Realizado:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(284, 26);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(123, 20);
            this.txtLocalidad.TabIndex = 3;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(222, 29);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(56, 13);
            this.lab.TabIndex = 2;
            this.lab.Text = "Localidad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Location = new System.Drawing.Point(857, 279);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar cliente";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Location = new System.Drawing.Point(727, 279);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Editar cliente";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbxDatosEdit
            // 
            this.gbxDatosEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatosEdit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxDatosEdit.Controls.Add(this.btnCancelEdit);
            this.gbxDatosEdit.Controls.Add(this.btnSaveEdit);
            this.gbxDatosEdit.Controls.Add(this.txtVehiculoEdit);
            this.gbxDatosEdit.Controls.Add(this.label2);
            this.gbxDatosEdit.Controls.Add(this.txtTelefonoEdit);
            this.gbxDatosEdit.Controls.Add(this.label6);
            this.gbxDatosEdit.Controls.Add(this.txtTrabajoEdit);
            this.gbxDatosEdit.Controls.Add(this.label7);
            this.gbxDatosEdit.Controls.Add(this.txtLocalidadEdit);
            this.gbxDatosEdit.Controls.Add(this.label8);
            this.gbxDatosEdit.Controls.Add(this.txtNameEdit);
            this.gbxDatosEdit.Controls.Add(this.label9);
            this.gbxDatosEdit.Enabled = false;
            this.gbxDatosEdit.Location = new System.Drawing.Point(12, 332);
            this.gbxDatosEdit.Name = "gbxDatosEdit";
            this.gbxDatosEdit.Size = new System.Drawing.Size(960, 128);
            this.gbxDatosEdit.TabIndex = 10;
            this.gbxDatosEdit.TabStop = false;
            this.gbxDatosEdit.Text = "Datos del cliente a editar";
            this.gbxDatosEdit.Visible = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.Azure;
            this.btnSaveEdit.Location = new System.Drawing.Point(777, 48);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(101, 34);
            this.btnSaveEdit.TabIndex = 7;
            this.btnSaveEdit.Text = "Guardar";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // txtVehiculoEdit
            // 
            this.txtVehiculoEdit.Location = new System.Drawing.Point(284, 62);
            this.txtVehiculoEdit.Name = "txtVehiculoEdit";
            this.txtVehiculoEdit.Size = new System.Drawing.Size(123, 20);
            this.txtVehiculoEdit.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vehículo:";
            // 
            // txtTelefonoEdit
            // 
            this.txtTelefonoEdit.Location = new System.Drawing.Point(62, 62);
            this.txtTelefonoEdit.Name = "txtTelefonoEdit";
            this.txtTelefonoEdit.Size = new System.Drawing.Size(123, 20);
            this.txtTelefonoEdit.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono:";
            // 
            // txtTrabajoEdit
            // 
            this.txtTrabajoEdit.Location = new System.Drawing.Point(449, 45);
            this.txtTrabajoEdit.Multiline = true;
            this.txtTrabajoEdit.Name = "txtTrabajoEdit";
            this.txtTrabajoEdit.Size = new System.Drawing.Size(293, 37);
            this.txtTrabajoEdit.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trabajo Realizado:";
            // 
            // txtLocalidadEdit
            // 
            this.txtLocalidadEdit.Location = new System.Drawing.Point(284, 26);
            this.txtLocalidadEdit.Name = "txtLocalidadEdit";
            this.txtLocalidadEdit.Size = new System.Drawing.Size(123, 20);
            this.txtLocalidadEdit.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Localidad:";
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Location = new System.Drawing.Point(62, 26);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(123, 20);
            this.txtNameEdit.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre:";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Azure;
            this.btnCancelEdit.Location = new System.Drawing.Point(884, 48);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(70, 34);
            this.btnCancelEdit.TabIndex = 10;
            this.btnCancelEdit.Text = "Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.BackColor = System.Drawing.Color.Azure;
            this.btnCancelNew.Location = new System.Drawing.Point(884, 45);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(70, 34);
            this.btnCancelNew.TabIndex = 11;
            this.btnCancelNew.Text = "Cancelar";
            this.btnCancelNew.UseVisualStyleBackColor = false;
            this.btnCancelNew.Click += new System.EventHandler(this.btnCancelNew_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.gbxDatosEdit);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbxClienteNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewCli);
            this.Controls.Add(this.btnCleanSearch);
            this.Controls.Add(this.dgvListCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarCli);
            this.Controls.Add(this.lblBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCliente)).EndInit();
            this.gbxClienteNew.ResumeLayout(false);
            this.gbxClienteNew.PerformLayout();
            this.gbxDatosEdit.ResumeLayout(false);
            this.gbxDatosEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarCli;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListCliente;
        private System.Windows.Forms.Button btnCleanSearch;
        private System.Windows.Forms.Button btnNewCli;
        private System.Windows.Forms.GroupBox gbxClienteNew;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbxDatosEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox txtVehiculoEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefonoEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrabajoEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalidadEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}