namespace Aluguer
{
    partial class fDetalle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDetalle));
			this.txbApeNom = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.btSair = new System.Windows.Forms.Button();
			this.btDevolver = new System.Windows.Forms.Button();
			this.btAlugar = new System.Windows.Forms.Button();
			this.txbNDias = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDataAlquiler = new System.Windows.Forms.DateTimePicker();
			this.lblCombustible = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txbApeNom
			// 
			this.txbApeNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbApeNom.Location = new System.Drawing.Point(17, 213);
			this.txbApeNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txbApeNom.Name = "txbApeNom";
			this.txbApeNom.Size = new System.Drawing.Size(407, 24);
			this.txbApeNom.TabIndex = 38;
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Label3.Location = new System.Drawing.Point(17, 192);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(408, 21);
			this.Label3.TabIndex = 37;
			this.Label3.Text = "apelidos e nome do alugador";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btSair
			// 
			this.btSair.Location = new System.Drawing.Point(301, 327);
			this.btSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btSair.Name = "btSair";
			this.btSair.Size = new System.Drawing.Size(124, 28);
			this.btSair.TabIndex = 36;
			this.btSair.Text = "Saír";
			this.btSair.UseVisualStyleBackColor = true;
			this.btSair.Click += new System.EventHandler(this.btSair_Click);
			// 
			// btDevolver
			// 
			this.btDevolver.Location = new System.Drawing.Point(169, 327);
			this.btDevolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btDevolver.Name = "btDevolver";
			this.btDevolver.Size = new System.Drawing.Size(124, 28);
			this.btDevolver.TabIndex = 35;
			this.btDevolver.Text = "Devolver";
			this.btDevolver.UseVisualStyleBackColor = true;
			this.btDevolver.Click += new System.EventHandler(this.btDevolver_Click);
			// 
			// btAlugar
			// 
			this.btAlugar.Location = new System.Drawing.Point(37, 327);
			this.btAlugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btAlugar.Name = "btAlugar";
			this.btAlugar.Size = new System.Drawing.Size(124, 28);
			this.btAlugar.TabIndex = 34;
			this.btAlugar.Text = "Alugar";
			this.btAlugar.UseVisualStyleBackColor = true;
			this.btAlugar.Click += new System.EventHandler(this.btAlugar_Click);
			// 
			// txbNDias
			// 
			this.txbNDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbNDias.Location = new System.Drawing.Point(281, 273);
			this.txbNDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txbNDias.Name = "txbNDias";
			this.txbNDias.Size = new System.Drawing.Size(143, 24);
			this.txbNDias.TabIndex = 33;
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Label2.Location = new System.Drawing.Point(281, 252);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(144, 21);
			this.Label2.TabIndex = 32;
			this.Label2.Text = "número de días";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Label1.Location = new System.Drawing.Point(17, 252);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(235, 21);
			this.Label1.TabIndex = 31;
			this.Label1.Text = "Data Aluguer";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpDataAlquiler
			// 
			this.dtpDataAlquiler.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataAlquiler.Location = new System.Drawing.Point(17, 274);
			this.dtpDataAlquiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpDataAlquiler.Name = "dtpDataAlquiler";
			this.dtpDataAlquiler.Size = new System.Drawing.Size(233, 22);
			this.dtpDataAlquiler.TabIndex = 30;
			// 
			// lblCombustible
			// 
			this.lblCombustible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblCombustible.ForeColor = System.Drawing.Color.White;
			this.lblCombustible.Location = new System.Drawing.Point(244, 156);
			this.lblCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCombustible.Name = "lblCombustible";
			this.lblCombustible.Size = new System.Drawing.Size(181, 25);
			this.lblCombustible.TabIndex = 29;
			this.lblCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblColor
			// 
			this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblColor.ForeColor = System.Drawing.Color.White;
			this.lblColor.Location = new System.Drawing.Point(17, 156);
			this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(219, 25);
			this.lblColor.TabIndex = 28;
			this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblModelo
			// 
			this.lblModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblModelo.ForeColor = System.Drawing.Color.White;
			this.lblModelo.Location = new System.Drawing.Point(244, 127);
			this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(181, 25);
			this.lblModelo.TabIndex = 27;
			this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMarca
			// 
			this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblMarca.ForeColor = System.Drawing.Color.White;
			this.lblMarca.Location = new System.Drawing.Point(17, 127);
			this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(219, 25);
			this.lblMarca.TabIndex = 26;
			this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(451, 94);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// fDetalle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 383);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txbApeNom);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.btSair);
			this.Controls.Add(this.btDevolver);
			this.Controls.Add(this.btAlugar);
			this.Controls.Add(this.txbNDias);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dtpDataAlquiler);
			this.Controls.Add(this.lblCombustible);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.lblMarca);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "fDetalle";
			this.Text = "detalle do aluguer";
			this.Load += new System.EventHandler(this.fDetalle_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txbApeNom;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btSair;
        internal System.Windows.Forms.Button btDevolver;
        internal System.Windows.Forms.Button btAlugar;
        internal System.Windows.Forms.TextBox txbNDias;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpDataAlquiler;
        internal System.Windows.Forms.Label lblCombustible;
        internal System.Windows.Forms.Label lblColor;
        internal System.Windows.Forms.Label lblModelo;
        internal System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}