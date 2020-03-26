using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using misMetodos;

namespace bd12_SeguroEscolar
{
    public partial class f_inicial : Form
    {
        clsBD oBaseDatos = new clsBD("..\\..\\..\\Alumnos.mdb");
		clsAlumno oAlumno = new clsAlumno();

		//misMetodos.rellenarListas RellenarListas = new rellenarListas();

		DataSet dsAlumno;

        public f_inicial()
        {
            InitializeComponent();
			oBaseDatos.abrirBD();
		}

		private void btBuscar_Click(object sender, EventArgs e)
		{
			dsAlumno = oAlumno.leerAlumnos(oBaseDatos);

			cbxBuscarAlumno.Items.Clear();

			int[] aColumnas = new int[] {1,2,3};
			misMetodos.rellenarListas.rellenarCombo(dsAlumno, cbxBuscarAlumno, aColumnas);

			//for (int i = 0; i < dsAlumno.Tables[0].Rows.Count; i++)
			//{
			//	cbxBuscarAlumno.Items.Add(dsAlumno.Tables[0].Rows[i][1] + " " + dsAlumno.Tables[0].Rows[i][2] + ", " + dsAlumno.Tables[0].Rows[i][3]);
			//}
		}

		private void btSalir_Click(object sender, EventArgs e)
		{
			oBaseDatos.cerrarBD();
			this.Close();
		}

		private void cbxBuscarAlumno_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] aCurso = { "ESO1", "ESO2", "ESO3", "ESO4" };
			double[] aPrecios = { 2, 2.5, 3, 3.5 };

			oAlumno.valorarPropiedades(dsAlumno, cbxBuscarAlumno.SelectedIndex);

			int materias = oAlumno.contarMaterias(oBaseDatos);
			DataSet dsCursoAlumno = oAlumno.leerCurso(oBaseDatos);

			if (materias == 0)
			{
				MessageBox.Show("El alumno no tiene matrícula en ningún curso. No es posible calcular el importe del seguro.", "Sin matrícula", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else
			{
				lblNMaterias.Text = materias.ToString();
				lblCurso.Text = dsCursoAlumno.Tables[0].Rows[0][1].ToString();

				double precio = aPrecios[Array.IndexOf(aCurso, dsCursoAlumno.Tables[0].Rows[0][0].ToString())];

				lblImporte.Text = precio.ToString();

				lblTotal.Text = Convert.ToString(precio * materias);
			}
		}

		private void btAbonarSeguro_Click(object sender, EventArgs e)
		{
			if(oAlumno.PagadoSE == "S")
			{
				MessageBox.Show("El alumno ya tiene abonado el seguro escolar.", "S.E. Abonado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("¿Guardar el abono del S.E.?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (respuesta == DialogResult.Yes)
				{
					oAlumno.abonarSeguro(oBaseDatos);
				}
				
			}
		}
	}
}
