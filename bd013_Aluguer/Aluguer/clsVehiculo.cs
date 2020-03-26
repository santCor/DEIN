using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Aluguer
{
    public class clsVehiculo
    {
        #region "prop privadas"
            private int _IdVehiculo;
            private string _Marca;
            private string _Modelo;
            private string _Color;
            private string _Combustible;
            private string _Alugado;
        #endregion

        #region "prop públicas"
        public int IdVehiculo
        {
            get { return this._IdVehiculo; }
            set { this._IdVehiculo = value; }
        }
        public string Marca
        {
            get { return _Marca; }
            set { this._Marca = value; }
        }
        public string Modelo
        {
            get { return _Modelo; }
            set { this._Modelo = value; }
        }
        public string Color
        {
            get { return _Color; }
            set { this._Color = value; }
        }
        public string Combustible
        {
            get { return _Combustible; }
            set { this._Combustible = value; }
        }
        public string Alugado
        {
            get { return _Alugado; }
            set { this._Alugado = value; }
        }
        #endregion

        public System.Data.DataSet leerVehiculos(clsBD oBaseDatos)
        {
            string cadenaSQL = "Select * from Vehiculos";
            return oBaseDatos.operacionsSelect(cadenaSQL);
        }

        public void colocarMarcaAlugado(clsBD oBaseDatos)
        {
            string cadenaSQL = string.Format("Update vehiculos set Alugado='{0}' where IdVehiculo={1}", this.Alugado, this.IdVehiculo);
            oBaseDatos.operacionsNonSelect(cadenaSQL);
        }

        public void EstablecerValores(DataSet DS, int Indice)
        {
            this.IdVehiculo = Convert.ToInt32(DS.Tables[0].Rows[Indice][0]);
            this.Marca = Convert.ToString(DS.Tables[0].Rows[Indice][1]);
            this.Modelo = Convert.ToString(DS.Tables[0].Rows[Indice][2]);
            this.Color = Convert.ToString(DS.Tables[0].Rows[Indice][3]);
            this.Combustible = Convert.ToString(DS.Tables[0].Rows[Indice][4]);
            this.Alugado = Convert.ToString(DS.Tables[0].Rows[Indice][5]);
        }
    }
}
