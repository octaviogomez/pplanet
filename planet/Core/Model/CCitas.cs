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
    public class CCitas
    {
        public string ProcedimientoGeneral = "PCitas";
        ManagerBD objManagerBD;
        public  int NoAlumno = 6;
        public CCitas()
        {
            objManagerBD = new ManagerBD();
        }
        #region Propiedaes
        public int pk_cita { get; set; }
        public int estado { get; set; }
        public string fecha { get; set; }
        public int fk_hora { get; set; }
        public int cupo { get; set; }
        public int NoProfes { get; set; }
        public int id_registro { get; set; }
        #endregion

        /// <summary>
        /// Creación de reservacion
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool CreacionCita(int opcion, CCitas obj)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_cita", SqlDbType.Int) { Value = obj.pk_cita });
            lstParametros.Add(new SqlParameter("@estado", SqlDbType.Int) { Value = obj.estado });
            lstParametros.Add(new SqlParameter("@fecha", SqlDbType.VarChar, 50) { Value = obj.fecha });
            lstParametros.Add(new SqlParameter("@fk_hora", SqlDbType.Int) { Value = obj.fk_hora });
            lstParametros.Add(new SqlParameter("@cupo", SqlDbType.Int) { Value = obj.cupo });
            lstParametros.Add(new SqlParameter("@NoProfes", SqlDbType.Int) { Value = obj.NoProfes });
            lstParametros.Add(new SqlParameter("@id_registro", SqlDbType.Int) { Value = obj.id_registro });
            objManagerBD = new ManagerBD();
            if (objManagerBD.Insert(ProcedimientoGeneral, lstParametros.ToArray()))
                return true;
            return false;
        }

        /// <summary>
        /// Lista cualquier forma la entidad de Citas
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="obj"></param>
        /// <param name="objDatos"></param>
        /// <returns></returns>
        public bool ListarCitas(int opcion, CCitas obj, ref DataSet objDatos) //Listar de cualquier forma
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            bool ExisteDatos = false;
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_cita", SqlDbType.Int) { Value = obj.pk_cita });
            lstParametros.Add(new SqlParameter("@estado", SqlDbType.Int) { Value = obj.estado });
            lstParametros.Add(new SqlParameter("@fecha", SqlDbType.VarChar, 50) { Value = obj.fecha });
            lstParametros.Add(new SqlParameter("@fk_hora", SqlDbType.Int) { Value = obj.fk_hora });
            lstParametros.Add(new SqlParameter("@cupo", SqlDbType.Int) { Value = obj.cupo });
            lstParametros.Add(new SqlParameter("@NoProfes", SqlDbType.Int) { Value = obj.NoProfes });
            lstParametros.Add(new SqlParameter("@id_registro", SqlDbType.Int) { Value = obj.id_registro });
            objDatos = objManagerBD.GetData(ProcedimientoGeneral, lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;

        }

        /// <summary>
        /// Elimina una reseracion mediante tu Pk
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool EliminarCita(int opcion, CCitas obj)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_cita", SqlDbType.Int) { Value = obj.pk_cita });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData(ProcedimientoGeneral, lstParametros.ToArray()))
                return true;
            return false;
        }
    }
    }
