namespace Aluguer
{
    partial class fInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInicial));
			this.btSair = new System.Windows.Forms.Button();
			this.dgvVehiculos = new System.Windows.Forms.DataGridView();
			this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alquilado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblVehiculoDia = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btSair
			// 
			this.btSair.Location = new System.Drawing.Point(456, 398);
			this.btSair.Margin = new System.Windows.Forms.Padding(4);
			this.btSair.Name = "btSair";
			this.btSair.Size = new System.Drawing.Size(124, 28);
			this.btSair.TabIndex = 14;
			this.btSair.Text = "Saír";
			this.btSair.UseVisualStyleBackColor = true;
			this.btSair.Click += new System.EventHandler(this.btSair_Click);
			// 
			// dgvVehiculos
			// 
			this.dgvVehiculos.AllowUserToAddRows = false;
			this.dgvVehiculos.AllowUserToDeleteRows = false;
			this.dgvVehiculos.AllowUserToResizeColumns = false;
			this.dgvVehiculos.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvVehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.Combustible,
            this.Alquilado});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvVehiculos.Location = new System.Drawing.Point(16, 162);
			this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvVehiculos.Name = "dgvVehiculos";
			this.dgvVehiculos.RowHeadersVisible = false;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVehiculos.Size = new System.Drawing.Size(564, 215);
			this.dgvVehiculos.TabIndex = 13;
			this.dgvVehiculos.Click += new System.EventHandler(this.dgvVehiculos_Click);
			// 
			// Marca
			// 
			this.Marca.DataPropertyName = "Marca";
			this.Marca.HeaderText = "Marca";
			this.Marca.Name = "Marca";
			this.Marca.ReadOnly = true;
			this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Modelo
			// 
			this.Modelo.DataPropertyName = "Modelo";
			this.Modelo.HeaderText = "Modelo";
			this.Modelo.Name = "Modelo";
			this.Modelo.ReadOnly = true;
			this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Combustible
			// 
			this.Combustible.DataPropertyName = "Combustible";
			this.Combustible.HeaderText = "Combustible";
			this.Combustible.Name = "Combustible";
			this.Combustible.ReadOnly = true;
			this.Combustible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Combustible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Alquilado
			// 
			this.Alquilado.DataPropertyName = "Alugado";
			this.Alquilado.HeaderText = "Alugado S/N";
			this.Alquilado.Name = "Alquilado";
			this.Alquilado.ReadOnly = true;
			this.Alquilado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Alquilado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(15, 138);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(565, 25);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Seleccione vehículo para alugar ou ver datos do aluguer";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-4, -9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(608, 138);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 446);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(565, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "vehículo del día";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVehiculoDia
			// 
			this.lblVehiculoDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblVehiculoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVehiculoDia.ForeColor = System.Drawing.Color.White;
			this.lblVehiculoDia.Location = new System.Drawing.Point(16, 470);
			this.lblVehiculoDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVehiculoDia.Name = "lblVehiculoDia";
			this.lblVehiculoDia.Size = new System.Drawing.Size(565, 25);
			this.lblVehiculoDia.TabIndex = 17;
			this.lblVehiculoDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 532);
			this.Controls.Add(this.lblVehiculoDia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btSair);
			this.Controls.Add(this.dgvVehiculos);
			this.Controls.Add(this.Label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "fInicial";
			this.Text = "Aluguer de vehículos";
			this.Load += new System.EventHandler(this.fInicial_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btSair;
        internal System.Windows.Forms.DataGridView dgvVehiculos;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblVehiculoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alquilado;
    }
}

