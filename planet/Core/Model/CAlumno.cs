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
        public  CAlumno(){
            objManagerBD = new ManagerBD();
        }

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

   

        #endregion
    }
}
