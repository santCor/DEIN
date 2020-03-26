using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_Tragaperras
{
    public partial class f_Tragaperras : Form
    {

		int jugadasAcumuladas = 0;

        public f_Tragaperras()
        {
            InitializeComponent();
        }

		private void monedas_Click(object sender, EventArgs e)
		{
			if (sender.Equals(bt02))
			{
				jugadasAcumuladas += 20;
			}
			else if (sender.Equals(bt01))
			{
				jugadasAcumuladas += 10;
			}
			else if (sender.Equals(bt50))
			{
				jugadasAcumuladas += 5;
			}
			else if (sender.Equals(bt20))
			{
				jugadasAcumuladas += 2;
			}

			lblXogadas.Text = jugadasAcumuladas.ToString();
			btXogar.Enabled = true;
		}

		String[] aImagenes = {"cereza.jpg", "fresa.jpg", "ciruela.jpg", "limon.jpg", "manzana.jpg", "melon.jpg", "naranja.jpg", "piña.jpg", "platano.jpg"};
		Random r= new Random();
		int fruta1, fruta2, fruta3;

		private void btXogar_Click(object sender, EventArgs e)
		{
			jugadasAcumuladas--;
			mostrar();

			reloj.Enabled = true;
			btDeter.Enabled = true;
			btXogar.Enabled = false;
		}

		private void reloj_Tick(object sender, EventArgs e)
		{
			fruta1 = r.Next(9);
			pbFruta1.Image = Image.FromFile("..\\..\\..\\imagenes\\" + aImagenes[fruta1]);
			fruta2 = r.Next(9);
			pbFruta2.Image = Image.FromFile("..\\..\\..\\imagenes\\" + aImagenes[fruta2]);
			fruta3 = r.Next(9);
			pbFruta3.Image = Image.FromFile("..\\..\\..\\imagenes\\" + aImagenes[fruta3]);

			btAcumular.Enabled = false;
			btCobrarPremio.Enabled = false;
			btCobrarAcumulado.Enabled = false;
			btConvertir.Enabled = false;
		}

		int premio, acumulado;

		private void btDeter_Click(object sender, EventArgs e)
		{
			btDeter.Enabled = false;
			reloj.Enabled = false;

			if (jugadasAcumuladas > 0)
			{
				btXogar.Enabled = true;
			}

			if (fruta1 == fruta2 && fruta2 == fruta3 && fruta3 == 0) // si salen 3 cerezas
			{
				premio += 50;
			}
			else if (fruta1 == fruta2 && fruta2 == fruta3)
			{
				premio += 10;
			}
			else if (fruta1 == fruta2 || fruta2 == fruta3)
			{
				premio += 5;
			}
			else if (fruta1 == fruta3)
			{
				premio += 2;
			}

			mostrar();

			if (premio > 0)
			{
				btAcumular.Enabled = true;
				btCobrarPremio.Enabled = true;
			}
			if(acumulado > 0)
			{
				btCobrarAcumulado.Enabled = true;
				btConvertir.Enabled = true;
			}
		}

		private void btCobrarPremio_Click(object sender, EventArgs e)
		{
			premio = 0;
			lblPremio.Text = premio.ToString();
			btAcumular.Enabled = false;
			btCobrarPremio.Enabled = false;
		}

		private void btAcumular_Click(object sender, EventArgs e)
		{
			acumulado += premio;
			premio = 0;

			mostrar();

			btCobrarAcumulado.Enabled = true;
			btConvertir.Enabled = true;
			btAcumular.Enabled = false;
			btCobrarPremio.Enabled = false;
		}

		private void btCobrarAcumulado_Click(object sender, EventArgs e)
		{
			acumulado = 0;
			mostrar();
			btCobrarAcumulado.Enabled = false;
			btConvertir.Enabled = false;
		}

		private void btConvertir_Click(object sender, EventArgs e)
		{
			jugadasAcumuladas += acumulado * 10;
			acumulado = 0;
			mostrar();
			btXogar.Enabled = true;
			btCobrarAcumulado.Enabled = false;
			btConvertir.Enabled = false;
		}

		public void mostrar()
		{
			lblAcumulado.Text = acumulado.ToString();
			lblXogadas.Text = jugadasAcumuladas.ToString();
			lblPremio.Text = premio.ToString();
		}

	}
}
