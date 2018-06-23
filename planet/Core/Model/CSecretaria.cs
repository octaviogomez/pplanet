using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using Core.Model;
namespace Core.Model
{
    public class CSecretaria
    {
        ManagerBD objManagerBD;
        private string procedimientoGeneral = "PSecretaria";
        public  CSecretaria() {
            objManagerBD = new ManagerBD();
        }
        #region Metodo de validación
        public bool AutentificarSecretaria(int opcion, ref DataSet objDatos, CSecretaria objAlumno)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_secreatria", SqlDbType.VarChar) { Value = objAlumno.pk_secreatria });
            lstParametros.Add(new SqlParameter("@clave", SqlDbType.VarChar) { Value = objAlumno.clave });
            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData(procedimientoGeneral, lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }
        #endregion

        #region Propiedades
        public int pk_secreatria { get; set; }
        public int rol { get; set; }
        public int id { get; set; }
        public string clave { get; set; }
        public int activo { get; set; }
        public string correo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string anioIngreso { get; set; }
        public string anioEgreso { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        #endregion
    }
}
