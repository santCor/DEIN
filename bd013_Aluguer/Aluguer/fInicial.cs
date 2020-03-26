using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aluguer
{
	public partial class fInicial : Form
	{
		clsBD oBaseDatos = new clsBD("..\\..\\..\\AluguerVehiculos.mdb");
		clsVehiculo oVehiculo = new clsVehiculo();

		DataSet dsVehiculos;
		int vehDia;
		

		public fInicial()
		{
			InitializeComponent();
		}

		private void fInicial_Load(object sender, EventArgs e)
		{
			oBaseDatos.abrirBD();
			cargarDataGrid();
			vehiculoDelDia();
		}

		private void cargarDataGrid()
		{
			dsVehiculos = oVehiculo.leerVehiculos(oBaseDatos);
			dgvVehiculos.DataSource = dsVehiculos.Tables[0];
		}

		private void vehiculoDelDia()
		{
			bool hayVehiculosDisponibles = false;
			for (int i = 0; i < dsVehiculos.Tables[0].Rows.Count; i++)
			{
				if (dsVehiculos.Tables[0].Rows[i][5].ToString().Equals("N"))
				{
					hayVehiculosDisponibles = true;
					break;
				}
			}
			if (hayVehiculosDisponibles)
			{
				bool fin = false;
				while (!fin)
				{
					Random r = new Random();
					int vehiculoDia = r.Next(dsVehiculos.Tables[0].Rows.Count);
					if (dsVehiculos.Tables[0].Rows[vehiculoDia][5].ToString().Equals("N"))
					{
						lblVehiculoDia.Text = dsVehiculos.Tables[0].Rows[vehiculoDia][1] + " " + dsVehiculos.Tables[0].Rows[vehiculoDia][2] + " " + dsVehiculos.Tables[0].Rows[vehiculoDia][4];
						vehDia = Convert.ToInt32(dsVehiculos.Tables[0].Rows[vehiculoDia][0]);
						fin = true;
					}
				}
			}
			else
			{
				lblVehiculoDia.Text = "No hay vehículos para alquilar";
			}
		}

		private void btSair_Click(object sender, EventArgs e)
		{
			oBaseDatos.cerrarBD();
			this.Close();
		}

		private void dgvVehiculos_Click(object sender, EventArgs e)
		{
			oVehiculo.EstablecerValores(dsVehiculos, dgvVehiculos.CurrentRow.Index);
			fDetalle fd = new fDetalle(oBaseDatos, oVehiculo);
			fd.ShowDialog();
			cargarDataGrid();

			if(vehDia == oVehiculo.IdVehiculo && oVehiculo.Alugado.Equals("S"))
			{
				vehiculoDelDia();
			}
		}
	}
}
