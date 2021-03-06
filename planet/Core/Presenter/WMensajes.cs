﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;

namespace Core.Presenter
{
    public class WMensajes
    {
        ManagerBD Manager;
        IMensajes ViewMensajes;
        CMensajes objMensajes;
        public WMensajes(IMensajes InterfazMensajes)
        {
            objMensajes = new CMensajes();
            Manager = new ManagerBD();
            ViewMensajes = InterfazMensajes;
        }
        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            SqlConnection sqlCon = Manager.GetConnection();
            if (sqlCon.State == ConnectionState.Open)
            {
                ConexcionAvierta = true;
            }
            return ConexcionAvierta;
        }
    }
}
