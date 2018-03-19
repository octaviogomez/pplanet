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
    public class CAvisoGenerales
    {
        ManagerBD objManagerBD;
        public CAvisoGenerales()
        {
            objManagerBD = new ManagerBD();
        }

        public bool ConsultaAvisoGeneral (int op,ref DataSet objDatos)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = op });
            objDatos = objManagerBD.GetData("PAvisoGenerales", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            
            return ExisteDatos;
        }
        #region Propiedes
        public int pk_avisosGenerales { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string Direccion { get; set; }
        #endregion
    }
}
