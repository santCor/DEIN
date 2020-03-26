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
    public partial class fDetalle : Form
    {
		clsBD oBaseDatos;
		clsVehiculo oVehiculo;
		clsAluguer oAluguer = new clsAluguer();

		DataSet dsAluguer;

		public fDetalle(clsBD oBD, clsVehiculo oVehiculo)
        {
            InitializeComponent();
			this.oBaseDatos = oBD;
			this.oVehiculo = oVehiculo;
        }

		private void fDetalle_Load(object sender, EventArgs e)
		{
			lblMarca.Text = oVehiculo.Marca;
			lblModelo.Text = oVehiculo.Modelo;
			lblColor.Text = oVehiculo.Color;
			lblCombustible.Text = oVehiculo.Combustible;

			if (oVehiculo.Alugado.Equals("S"))
			{
				vehiculoAlquilado();
			}
			else
			{
				btAlugar.Enabled = true;
				btDevolver.Enabled = false;
			}
		}

		private void vehiculoAlquilado()
		{
			btAlugar.Enabled = false;
			btDevolver.Enabled = true;

			oAluguer.IdVehiculo = oVehiculo.IdVehiculo;
			dsAluguer = oAluguer.LeerAluguer(oBaseDatos);
			oAluguer.EstablecerValores(dsAluguer, 0);

			txbApeNom.Text = oAluguer.ApeNom;
			txbNDias.Text = oAluguer.NDias.ToString();
			dtpDataAlquiler.Value = oAluguer.DataAluguer;
		}

		private void btAlugar_Click(object sender, EventArgs e)
		{
			DialogResult respuesta;
			respuesta = MessageBox.Show("Registar alquiler en la BD y marcar como vehículo alquilado?", "guardar alquiler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(respuesta == DialogResult.Yes)
			{
				oAluguer.IdVehiculo = oVehiculo.IdVehiculo;
				oAluguer.ApeNom = txbApeNom.Text;
				oAluguer.NDias = Convert.ToInt32(txbNDias.Text);
				oAluguer.DataAluguer = dtpDataAlquiler.Value;

				oAluguer.EngadirAluguer(oBaseDatos);
				oVehiculo.Alugado = "S";
				oVehiculo.colocarMarcaAlugado(oBaseDatos);

				MessageBox.Show("alquiler registrado en la base de datos", "acción finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			this.Close();
		}

		private void btDevolver_Click(object sender, EventArgs e)
		{
			DialogResult respuesta;
			respuesta = MessageBox.Show("Devolver vehículo y marcar como NO alquilado?", "fin alquiler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (respuesta == DialogResult.Yes)
			{
				oAluguer.BorrarAluguer(oBaseDatos);

				oVehiculo.Alugado = "N";
				oVehiculo.colocarMarcaAlugado(oBaseDatos);

				MessageBox.Show("alquiler borrado de la base de datos", "acción finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			this.Close();
		}

		private void btSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
