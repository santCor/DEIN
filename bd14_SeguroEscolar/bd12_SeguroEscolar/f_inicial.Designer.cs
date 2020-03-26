namespace bd12_SeguroEscolar
{
    partial class f_inicial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_inicial));
			this.gbSeguro = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.lblImporte = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblCurso = new System.Windows.Forms.Label();
			this.lblNMaterias = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.btSalir = new System.Windows.Forms.Button();
			this.btAbonarSeguro = new System.Windows.Forms.Button();
			this.gbDatosAlumno = new System.Windows.Forms.GroupBox();
			this.cbxBuscarAlumno = new System.Windows.Forms.ComboBox();
			this.btBuscar = new System.Windows.Forms.Button();
			this.lblTextSE = new System.Windows.Forms.Label();
			this.gbSeguro.SuspendLayout();
			this.gbDatosAlumno.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbSeguro
			// 
			this.gbSeguro.Controls.Add(this.Label4);
			this.gbSeguro.Controls.Add(this.lblImporte);
			this.gbSeguro.Controls.Add(this.Label9);
			this.gbSeguro.Controls.Add(this.Label1);
			this.gbSeguro.Controls.Add(this.Label2);
			this.gbSeguro.Controls.Add(this.Label6);
			this.gbSeguro.Controls.Add(this.lblTotal);
			this.gbSeguro.Controls.Add(this.lblCurso);
			this.gbSeguro.Controls.Add(this.lblNMaterias);
			this.gbSeguro.Controls.Add(this.Label8);
			this.gbSeguro.Location = new System.Drawing.Point(11, 140);
			this.gbSeguro.Name = "gbSeguro";
			this.gbSeguro.Size = new System.Drawing.Size(448, 144);
			this.gbSeguro.TabIndex = 47;
			this.gbSeguro.TabStop = false;
			this.gbSeguro.Text = "Datos do Seguro Escolar";
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(176, 80);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(96, 16);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Importe";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblImporte
			// 
			this.lblImporte.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblImporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImporte.Location = new System.Drawing.Point(176, 96);
			this.lblImporte.Name = "lblImporte";
			this.lblImporte.Size = new System.Drawing.Size(96, 24);
			this.lblImporte.TabIndex = 17;
			this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label9
			// 
			this.Label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label9.Location = new System.Drawing.Point(288, 96);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(32, 24);
			this.Label9.TabIndex = 22;
			this.Label9.Text = "=";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(16, 80);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 16);
			this.Label1.TabIndex = 16;
			this.Label1.Text = "nºmaterias";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(16, 32);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(416, 16);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "curso";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label6.Location = new System.Drawing.Point(336, 80);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(96, 16);
			this.Label6.TabIndex = 20;
			this.Label6.Text = "Total";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(336, 96);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(96, 24);
			this.lblTotal.TabIndex = 19;
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCurso
			// 
			this.lblCurso.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCurso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurso.Location = new System.Drawing.Point(16, 48);
			this.lblCurso.Name = "lblCurso";
			this.lblCurso.Size = new System.Drawing.Size(416, 24);
			this.lblCurso.TabIndex = 13;
			this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNMaterias
			// 
			this.lblNMaterias.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblNMaterias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNMaterias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNMaterias.Location = new System.Drawing.Point(16, 96);
			this.lblNMaterias.Name = "lblNMaterias";
			this.lblNMaterias.Size = new System.Drawing.Size(96, 24);
			this.lblNMaterias.TabIndex = 15;
			this.lblNMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label8
			// 
			this.Label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label8.Location = new System.Drawing.Point(128, 96);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(32, 24);
			this.Label8.TabIndex = 21;
			this.Label8.Text = "x";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btSalir
			// 
			this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
			this.btSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btSalir.Location = new System.Drawing.Point(569, 323);
			this.btSalir.Name = "btSalir";
			this.btSalir.Size = new System.Drawing.Size(96, 48);
			this.btSalir.TabIndex = 46;
			this.btSalir.Text = "Saír";
			this.btSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
			// 
			// btAbonarSeguro
			// 
			this.btAbonarSeguro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btAbonarSeguro.Location = new System.Drawing.Point(477, 228);
			this.btAbonarSeguro.Name = "btAbonarSeguro";
			this.btAbonarSeguro.Size = new System.Drawing.Size(96, 32);
			this.btAbonarSeguro.TabIndex = 45;
			this.btAbonarSeguro.Text = "Abonar Seguro";
			this.btAbonarSeguro.Click += new System.EventHandler(this.btAbonarSeguro_Click);
			// 
			// gbDatosAlumno
			// 
			this.gbDatosAlumno.Controls.Add(this.cbxBuscarAlumno);
			this.gbDatosAlumno.Location = new System.Drawing.Point(5, 55);
			this.gbDatosAlumno.Name = "gbDatosAlumno";
			this.gbDatosAlumno.Size = new System.Drawing.Size(568, 56);
			this.gbDatosAlumno.TabIndex = 44;
			this.gbDatosAlumno.TabStop = false;
			this.gbDatosAlumno.Text = "Datos Alumno";
			// 
			// cbxBuscarAlumno
			// 
			this.cbxBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxBuscarAlumno.FormattingEnabled = true;
			this.cbxBuscarAlumno.Location = new System.Drawing.Point(6, 19);
			this.cbxBuscarAlumno.Name = "cbxBuscarAlumno";
			this.cbxBuscarAlumno.Size = new System.Drawing.Size(549, 24);
			this.cbxBuscarAlumno.TabIndex = 0;
			this.cbxBuscarAlumno.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarAlumno_SelectedIndexChanged);
			// 
			// btBuscar
			// 
			this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
			this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btBuscar.Location = new System.Drawing.Point(579, 61);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(86, 50);
			this.btBuscar.TabIndex = 43;
			this.btBuscar.Text = "Buscar Alumno";
			this.btBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
			// 
			// lblTextSE
			// 
			this.lblTextSE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTextSE.BackColor = System.Drawing.Color.PowderBlue;
			this.lblTextSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextSE.Location = new System.Drawing.Point(0, -2);
			this.lblTextSE.Name = "lblTextSE";
			this.lblTextSE.Size = new System.Drawing.Size(690, 40);
			this.lblTextSE.TabIndex = 42;
			this.lblTextSE.Text = "Seguro Escolar";
			this.lblTextSE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// f_inicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 389);
			this.Controls.Add(this.gbSeguro);
			this.Controls.Add(this.btSalir);
			this.Controls.Add(this.btAbonarSeguro);
			this.Controls.Add(this.gbDatosAlumno);
			this.Controls.Add(this.btBuscar);
			this.Controls.Add(this.lblTextSE);
			this.Name = "f_inicial";
			this.Text = "Form1";
			this.gbSeguro.ResumeLayout(false);
			this.gbDatosAlumno.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbSeguro;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblImporte;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblCurso;
        internal System.Windows.Forms.Label lblNMaterias;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btSalir;
        internal System.Windows.Forms.Button btAbonarSeguro;
        internal System.Windows.Forms.GroupBox gbDatosAlumno;
        internal System.Windows.Forms.ComboBox cbxBuscarAlumno;
        internal System.Windows.Forms.Button btBuscar;
        internal System.Windows.Forms.Label lblTextSE;
    }
}

