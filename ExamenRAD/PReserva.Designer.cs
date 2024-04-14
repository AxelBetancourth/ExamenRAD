namespace ExamenRAD
{
    partial class PReserva
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtReservaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgReserva = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bClientes = new System.Windows.Forms.Button();
            this.bTeatros = new System.Windows.Forms.Button();
            this.txtTeatroId = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtNombreTeatro = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Fecha de Reserva:";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(800, 61);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(262, 22);
            this.dtpFechaReserva.TabIndex = 64;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(579, 203);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 38);
            this.BtnEliminar.TabIndex = 63;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(473, 203);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 38);
            this.BtnGuardar.TabIndex = 62;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtReservaId
            // 
            this.txtReservaId.Location = new System.Drawing.Point(172, 59);
            this.txtReservaId.Name = "txtReservaId";
            this.txtReservaId.ReadOnly = true;
            this.txtReservaId.Size = new System.Drawing.Size(100, 22);
            this.txtReservaId.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Teatros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Reserva Id";
            // 
            // dgReserva
            // 
            this.dgReserva.AllowUserToAddRows = false;
            this.dgReserva.AllowUserToDeleteRows = false;
            this.dgReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReserva.Location = new System.Drawing.Point(36, 261);
            this.dgReserva.Name = "dgReserva";
            this.dgReserva.ReadOnly = true;
            this.dgReserva.RowHeadersWidth = 51;
            this.dgReserva.RowTemplate.Height = 24;
            this.dgReserva.Size = new System.Drawing.Size(1026, 296);
            this.dgReserva.TabIndex = 53;
            this.dgReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReserva_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Gestión Reserva";
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(172, 105);
            this.bClientes.Margin = new System.Windows.Forms.Padding(4);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(260, 28);
            this.bClientes.TabIndex = 66;
            this.bClientes.Text = "Buscar";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bTeatros
            // 
            this.bTeatros.Location = new System.Drawing.Point(172, 151);
            this.bTeatros.Margin = new System.Windows.Forms.Padding(4);
            this.bTeatros.Name = "bTeatros";
            this.bTeatros.Size = new System.Drawing.Size(260, 28);
            this.bTeatros.TabIndex = 67;
            this.bTeatros.Text = "Buscar";
            this.bTeatros.UseVisualStyleBackColor = true;
            this.bTeatros.Click += new System.EventHandler(this.bTeatros_Click);
            // 
            // txtTeatroId
            // 
            this.txtTeatroId.Location = new System.Drawing.Point(653, 151);
            this.txtTeatroId.Name = "txtTeatroId";
            this.txtTeatroId.ReadOnly = true;
            this.txtTeatroId.Size = new System.Drawing.Size(70, 22);
            this.txtTeatroId.TabIndex = 77;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(653, 103);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(70, 22);
            this.txtClienteId.TabIndex = 76;
            // 
            // txtNombreTeatro
            // 
            this.txtNombreTeatro.Location = new System.Drawing.Point(749, 151);
            this.txtNombreTeatro.Name = "txtNombreTeatro";
            this.txtNombreTeatro.ReadOnly = true;
            this.txtNombreTeatro.Size = new System.Drawing.Size(313, 22);
            this.txtNombreTeatro.TabIndex = 75;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(749, 105);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(313, 22);
            this.txtNombreCliente.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Teatros:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Clientes:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 567);
            this.Controls.Add(this.txtTeatroId);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.txtNombreTeatro);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bTeatros);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtReservaId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReserva);
            this.Controls.Add(this.label1);
            this.Name = "PReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PReserva";
            this.Load += new System.EventHandler(this.PReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtReservaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bTeatros;
        private System.Windows.Forms.TextBox txtTeatroId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtNombreTeatro;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}