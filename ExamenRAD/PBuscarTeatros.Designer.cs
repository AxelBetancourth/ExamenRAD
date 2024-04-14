namespace ExamenRAD
{
    partial class PBuscarTeatros
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
            this.dgTeatros = new System.Windows.Forms.DataGridView();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeatros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeatros
            // 
            this.dgTeatros.AllowUserToAddRows = false;
            this.dgTeatros.AllowUserToDeleteRows = false;
            this.dgTeatros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeatros.Location = new System.Drawing.Point(29, 114);
            this.dgTeatros.Name = "dgTeatros";
            this.dgTeatros.ReadOnly = true;
            this.dgTeatros.RowHeadersWidth = 51;
            this.dgTeatros.RowTemplate.Height = 24;
            this.dgTeatros.Size = new System.Drawing.Size(742, 313);
            this.dgTeatros.TabIndex = 16;
            this.dgTeatros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTeatros_CellDoubleClick);
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivos.Location = new System.Drawing.Point(29, 76);
            this.cbActivos.Margin = new System.Windows.Forms.Padding(4);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(151, 22);
            this.cbActivos.TabIndex = 15;
            this.cbActivos.Text = "Filtrar solo activos";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione el Teatro";
            // 
            // PBuscarTeatros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgTeatros);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.label1);
            this.Name = "PBuscarTeatros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBuscarTeatros";
            this.Load += new System.EventHandler(this.PBuscarTeatros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTeatros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTeatros;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.Label label1;
    }
}