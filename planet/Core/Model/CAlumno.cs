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
    public class CAlumno
    {
        public CAlumno() {
            objManagerBD = new ManagerBD();
        }


        //Validar Alumno
        public bool ValidarAlumno(int opcion, ref DataSet objDatos, CAlumno objAlumno)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@alu_NumControl", SqlDbType.NVarChar, 50) { Value = objAlumno.alu_NumControl });
            lstParametros.Add(new SqlParameter("@alu_Password", SqlDbType.NVarChar, 50) { Value = objAlumno.alu_Password });
            lstParametros.Add(new SqlParameter("@alu_Rol", SqlDbType.NVarChar, 50) { Value = objAlumno.alu_Rol });
            objDatos = objManagerBD.GetData("PAlumno", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            
            return ExisteDatos;
        }
        public bool ActualizarDatos( ref DataSet objDatos, CAlumno objAlumno)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = 2 });
            lstParametros.Add(new SqlParameter("@alu_NumControl", SqlDbType.NVarChar, 50) { Value =  objAlumno.alu_NumControl });

            objDatos = objManagerBD.GetData("PAlumno", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        public bool cambiarContrasenia(int opcion, CAlumno objAlumno)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@alu_NumControl", SqlDbType.VarChar) { Value = objAlumno.alu_NumControl });
            lstParametros.Add(new SqlParameter("@alu_Password", SqlDbType.VarChar) { Value = objAlumno.alu_Password });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PAlumno", lstParametros.ToArray()))
            {
                return true;
            }

            return false;
        }

        public bool ConfigurarUsuario(int opcion, CAlumno objAlumno)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value =opcion});
          
            lstParametros.Add(new SqlParameter("@alu_NumControl", SqlDbType.VarChar) { Value = objAlumno.alu_NumControl });
            lstParametros.Add(new SqlParameter("@alu_Password", SqlDbType.VarChar) { Value = objAlumno.alu_Password });
            lstParametros.Add(new SqlParameter("@Noseguro", SqlDbType.VarChar) { Value = objAlumno.Noseguro });
            lstParametros.Add(new SqlParameter("@curp", SqlDbType.VarChar) { Value = objAlumno.curp });


            //falta
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PAlumno", lstParametros.ToArray()))
            {
                return true;
            }

            return false;
        }

        #region Variables del usuario
        ManagerBD objManagerBD;
        //para consulta
        public string pk_Reservacion { get; set; }

        //Datos
        public int alu_ID { get; set; }
        public int alu_E1 { get; set; }
        public int alu_E2 { get; set; }
        public int alu_E3 { get; set; }
        public int alu_Rol { get; set; }
        public string alu_NumControl { get; set; }
        public string alu_Nombre { get; set; }
        public string alu_ApePaterno { get; set; }
        public string alu_ApeMaterno { get; set; }
        public string alu_Sexo { get; set; }
        public string alu_Password { get; set; }
        public string alu_FechaNacimiento { get; set; }
        public string alu_Carrera { get; set; }
        public string Noseguro { get; set; }
        public string curp { get; set; }
        public string AnioRegistro { get; set; }

        public int alu_ConestetoEncuesta { get; set; }
        public string tipo_usuario { get; set; }
        #endregion


    }
}
