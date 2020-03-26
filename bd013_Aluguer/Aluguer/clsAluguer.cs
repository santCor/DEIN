using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Aluguer
{
    class clsAluguer
    {
        #region "prop privadas"
            private int _IdAluguer;
            private int _IdVehiculo;
            private string _ApeNom;
            private DateTime _DataAluguer;
            private int _NDias;
        #endregion

        #region "prop públicas"
        public int IdAluguer
        {
            get { return this._IdAluguer; }
            set { this._IdAluguer = value; }
        }

        public int IdVehiculo
        {
            get { return this._IdVehiculo; }
            set { this._IdVehiculo = value; }
        }
        public string ApeNom
        {
            get { return _ApeNom; }
            set { this._ApeNom = value; }
        }
        public DateTime DataAluguer
        {
            get { return _DataAluguer; }
            set { this._DataAluguer = value; }
        }
        public int NDias
        {
            get { return this._NDias; }
            set { this._NDias = value; }
        }
        #endregion


        public System.Data.DataSet LeerAluguer(clsBD oBaseDatos)
        {
            string cadenaSQL = string.Format("select * from aluguer where idVehiculo={0}", this.IdVehiculo);
            return oBaseDatos.operacionsSelect(cadenaSQL);
        }
        public void EngadirAluguer(clsBD oBaseDatos)
        {
            string cadenaSQL = String.Format(@"insert into Aluguer(IdVehiculo,Apenom,DataAluguer,NDias) values 
                                             ({0},'{1}','{2}',{3})", this.IdVehiculo, this.ApeNom, this.DataAluguer, this.NDias);
            oBaseDatos.operacionsNonSelect(cadenaSQL);
        }
        public void BorrarAluguer(clsBD oBaseDatos)
        {
            string cadenaSQL = String.Format("delete from aluguer where IdAluguer={0}", this.IdAluguer);
            oBaseDatos.operacionsNonSelect(cadenaSQL);
        }

        public void EstablecerValores(DataSet DS, int Indice)
        {
            this.IdAluguer = Convert.ToInt32(DS.Tables[0].Rows[Indice][0]);
            this.IdVehiculo = Convert.ToInt32(DS.Tables[0].Rows[Indice][1]);
            this.ApeNom = Convert.ToString(DS.Tables[0].Rows[Indice][2]);
            this.DataAluguer = Convert.ToDateTime(DS.Tables[0].Rows[Indice][3]);
            this.NDias = Convert.ToInt32(DS.Tables[0].Rows[Indice][4]);
        }
    }
}
