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
        ManagerBD objManagerBD;
        string ProcedimientoGeneral = "Alumno";
        public  CAlumno(){
            objManagerBD = new ManagerBD();
        }
        /// <summary>
        /// Create student
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool CreateAlumno(int opcion, CAlumno obj)
        {
            bool registro = false;
            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
                lstParametros.Add(new SqlParameter("@pk_alumno", SqlDbType.Int) { Value = obj.pk_alumno });
                lstParametros.Add(new SqlParameter("@id", SqlDbType.Int) { Value = obj.id });
                lstParametros.Add(new SqlParameter("@clave", SqlDbType.VarChar) { Value = obj.clave });
                lstParametros.Add(new SqlParameter("@activo", SqlDbType.VarChar) { Value = obj.activo });
                lstParametros.Add(new SqlParameter("@correo", SqlDbType.VarChar) { Value = obj.correo });
                lstParametros.Add(new SqlParameter("@nombre", SqlDbType.VarChar) { Value = obj.nombre });
                lstParametros.Add(new SqlParameter("@apellidos", SqlDbType.VarChar) { Value = obj.apellidos });
                lstParametros.Add(new SqlParameter("@anioIngreso", SqlDbType.VarChar) { Value = obj.anioIngreso });
                lstParametros.Add(new SqlParameter("@anioEgreso", SqlDbType.VarChar) { Value = obj.anioEgreso });
                lstParametros.Add(new SqlParameter("@estadoPago", SqlDbType.Int) { Value = obj.estadoPago });
                lstParametros.Add(new SqlParameter("@facebook", SqlDbType.VarChar) { Value = obj.facebook });
                lstParametros.Add(new SqlParameter("@telefono", SqlDbType.VarChar) { Value = obj.telefono });
                lstParametros.Add(new SqlParameter("@celular", SqlDbType.VarChar) { Value = obj.celular });
                lstParametros.Add(new SqlParameter("@edad", SqlDbType.VarChar) { Value = obj.edad });
                lstParametros.Add(new SqlParameter("@sexo", SqlDbType.VarChar) { Value = obj.sexo });
                lstParametros.Add(new SqlParameter("@nivel", SqlDbType.VarChar) { Value = obj.nivel });
                lstParametros.Add(new SqlParameter("@direccion", SqlDbType.VarChar) { Value = obj.direccion });
                lstParametros.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date) { Value = obj.FechaNacimiento });
                objManagerBD = new ManagerBD();
                if (objManagerBD.UpdateData(ProcedimientoGeneral, lstParametros.ToArray())) {
                    registro = true;
                }
            }
            catch (Exception)
            {
                registro = false;
            }
            return registro;
        }
        /// <summary>
        /// Realiza las openracion de un crud generico
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool CRUD(int opcion, CAlumno obj)
        {
            bool registro = false;
            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
                lstParametros.Add(new SqlParameter("@pk_alumno", SqlDbType.Int) { Value = obj.pk_alumno });
                lstParametros.Add(new SqlParameter("@id", SqlDbType.Int) { Value = obj.id });
                lstParametros.Add(new SqlParameter("@clave", SqlDbType.VarChar) { Value = obj.clave });
                lstParametros.Add(new SqlParameter("@activo", SqlDbType.VarChar) { Value = obj.activo });
                lstParametros.Add(new SqlParameter("@correo", SqlDbType.VarChar) { Value = obj.correo });
                lstParametros.Add(new SqlParameter("@nombre", SqlDbType.VarChar) { Value = obj.nombre });
                lstParametros.Add(new SqlParameter("@apellidos", SqlDbType.VarChar) { Value = obj.apellidos });
                lstParametros.Add(new SqlParameter("@anioIngreso", SqlDbType.VarChar) { Value = obj.anioIngreso });
                lstParametros.Add(new SqlParameter("@anioEgreso", SqlDbType.VarChar) { Value = obj.anioEgreso });
                lstParametros.Add(new SqlParameter("@estadoPago", SqlDbType.Int) { Value = obj.estadoPago });
                lstParametros.Add(new SqlParameter("@facebook", SqlDbType.VarChar) { Value = obj.facebook });
                lstParametros.Add(new SqlParameter("@telefono", SqlDbType.VarChar) { Value = obj.telefono });
                lstParametros.Add(new SqlParameter("@celular", SqlDbType.VarChar) { Value = obj.celular });
                lstParametros.Add(new SqlParameter("@edad", SqlDbType.VarChar) { Value = obj.edad });
                lstParametros.Add(new SqlParameter("@sexo", SqlDbType.VarChar) { Value = obj.sexo });
                lstParametros.Add(new SqlParameter("@nivel", SqlDbType.VarChar) { Value = obj.nivel });
                lstParametros.Add(new SqlParameter("@direccion", SqlDbType.VarChar) { Value = obj.direccion });
                lstParametros.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date) { Value = obj.FechaNacimiento });
                objManagerBD = new ManagerBD();
                if (objManagerBD.UpdateData(ProcedimientoGeneral, lstParametros.ToArray()))
                {
                    registro = true;
                }
            }
            catch (Exception)
            {
                registro = false;
            }
            return registro;
        }
        /// <summary>
        /// Lista de manera general, dependinedo la opcion del procedimiento
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="obj"></param>
        /// <param name="objDatos"></param>
        /// <returns></returns>
        public bool ListarAlumno(int opcion, CAlumno obj, ref DataSet objDatos) //Listar de cualquier forma
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            bool ExisteDatos = false;
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_alumno", SqlDbType.Int) { Value = obj.pk_alumno });

            objDatos = objManagerBD.GetData(ProcedimientoGeneral, lstParametros.ToArray());
            
           
            if (objDatos.Tables[0].Rows.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;

        }
    
        #region Metodo de valicacion
        public bool AutentificarAlumno(int opcion, ref DataSet objDatos, CAlumno objAlumno)
        {
            bool ExisteDatos = false;
            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
                lstParametros.Add(new SqlParameter("@rol", SqlDbType.Int) { Value = objAlumno.rol });
                lstParametros.Add(new SqlParameter("@clave", SqlDbType.VarChar) { Value = objAlumno.clave });
                lstParametros.Add(new SqlParameter("@pk_alumno", SqlDbType.Int) { Value = objAlumno.pk_alumno });
                objDatos = objManagerBD.GetData(ProcedimientoGeneral, lstParametros.ToArray());
                objManagerBD = null;
                if (objDatos.Tables[0].Rows.Count > 0)
                    ExisteDatos = true;

            }
            catch (Exception e)
            {
                ExisteDatos = false;

            }
           

            return ExisteDatos;
        }
        #endregion


        #region Variables
        public int pk_alumno { get; set; }

        public int rol { get; set; }

        public int id { get; set; }

        public string clave { get; set; }

        public int activo { get; set; }

        public string correo { get; set; }

        public string nombre { get; set; }

        public string apellidos { get; set; }

        public string anioIngreso { get; set; }

        public string anioEgreso { get; set; }

        public int estadoPago { get; set; }

        public string facebook { get; set; }

        public string telefono { get; set; }

        public string celular { get; set; }

        public string sexo { get; set; }

        public int edad { get; set; }

        public int nivel { get; set; }

        public string direccion { get; set; }

        public int noClubs { get; set; }

        public int noPelis { get; set; }
        public string FechaNacimiento { get; set; }


        #endregion
    }
}
