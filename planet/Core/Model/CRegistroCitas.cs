﻿using System;
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
    public class CRegistroCitas
    {
        public string ProcedimientoGeneral = "PRegistroCitas";
        ManagerBD objManagerBD;
        public CRegistroCitas()
        {
            objManagerBD = new ManagerBD();
        }

        #region Propiedades
        public int pk_registroCita { get; set; }

        public int fk_cita { get; set; }

        public int fk_alumno { get; set; }

        public int fk_tipoCitas { get; set; }

        public int estadoReservacion { get; set; }

        public int fk_lecciones { get; set; }
        public string fecha { get; set; }
        #endregion

        public bool ListarCitas(int opcion, CRegistroCitas obj, ref DataSet objDatos) //Listar de cualquier forma
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            bool ExisteDatos = false;
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Fecha", SqlDbType.VarChar) { Value = obj.fecha });

            objDatos = objManagerBD.GetData(ProcedimientoGeneral, lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;

        }

    }
}