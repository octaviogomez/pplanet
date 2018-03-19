using System;
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
    public class WCitas
    {

        ManagerBD Manager;
        ICitas ViewCitas;
        CCitas objCitas;
        public WCitas(ICitas InterfazCitas)
        {
            objCitas = new CCitas();
            Manager = new ManagerBD();
            ViewCitas = InterfazCitas;
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
        public void CrearCita(int opcion,CCitas objCita)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objCita.CreacionCita(opcion, objCita);
                if (BolRegistro == true)
                    ViewCitas.Mensaje("Cita registrado", 1);
                else
                    ViewCitas.Mensaje("Cita no reguistrado, cheque sus datos", 2);
                
            }
        }

        public void ListadoDeCitas(CCitas objCita, int opcion)
        {
            DataSet dtsDatos = new DataSet();
            CCitas objaux = new CCitas();
            bool BolRegistro = false;
            if (ExisteConexion())
            {
               BolRegistro = objaux.ListarCitas(opcion, objCita,ref dtsDatos); 
                
                if (BolRegistro == true)
                {
                    ViewCitas.ListadoDt = dtsDatos;
                    ViewCitas.Mensaje("Listado correcto", 1);
                }
                else
                {
                    ViewCitas.Mensaje("Error no se pudieron listas ", 2);
                }
            }
        }
        public void EliminarCita(int opcion, CCitas objCita)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objCita.EliminarCita(opcion, objCita);
                if (BolRegistro == true)
                    ViewCitas.Mensaje("Cita eliminada", 4);
                else
                    ViewCitas.Mensaje("Cita no eliminada, cheque sus datos", 5);

            }
        }
    }
}
