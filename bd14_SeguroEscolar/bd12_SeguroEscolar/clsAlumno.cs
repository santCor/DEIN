using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd12_SeguroEscolar
{
    class clsAlumno
    {
        #region "p privadas"
        private string _idAlumno;
        private string _Apelido1;
        private string _Apelido2;
        private string _Nome;
        private string _PagadoSE;
        #endregion
        #region "p públicas"
        public string IdAlumno
        {
            get
            {
                return _idAlumno;
            }

            set
            {
                _idAlumno = value;
            }
        }

        public string Apelido1
        {
            get
            {
                return _Apelido1;
            }

            set
            {
                _Apelido1 = value;
            }
        }

        public string Apelido2
        {
            get
            {
                return _Apelido2;
            }

            set
            {
                _Apelido2 = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string PagadoSE
        {
            get
            {
                return _PagadoSE;
            }

            set
            {
                _PagadoSE = value;
            }
        }
        #endregion


        public System.Data.DataSet leerAlumnos(clsBD oBD)
        {
            string cadenaSQL = "select * from alumnos";
            return oBD.operacionsSelect(cadenaSQL);
        }

        public void abonarSeguro(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format("update alumnos set PagadoSE='S' where idAlumno='{0}'", this.IdAlumno);
            oBD.operacionsNonSelect(cadenaSQL);
        }

        public int contarMaterias(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format("select count(idAlumno) from materiasalumno where idAlumno='{0}'", this.IdAlumno);
            return oBD.operacionsScalar(cadenaSQL);
        }

        public void valorarPropiedades(System.Data.DataSet ds, int i)
        {
            this.IdAlumno = Convert.ToString(ds.Tables[0].Rows[i][0]);
            this.Apelido1= Convert.ToString(ds.Tables[0].Rows[i][1]);
            this.Apelido2= Convert.ToString(ds.Tables[0].Rows[i][2]);
            this.Nome= Convert.ToString(ds.Tables[0].Rows[i][3]);

            this.PagadoSE= Convert.ToString(ds.Tables[0].Rows[i][10]);
        }

        public System.Data.DataSet leerCurso(clsBD oBD)
        {
            string cadenaSQL;
            cadenaSQL = string.Format(@"select distinct(MateriasAlumno.idcurso),Cursos.NomeCurso from MateriasAlumno inner join Cursos
                                        on MateriasAlumno.idcurso=cursos.idcurso where MateriasAlumno.idalumno='{0}'",this.IdAlumno);
            return oBD.operacionsSelect(cadenaSQL);
        }
    }
}
