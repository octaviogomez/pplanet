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

        public  CSecretaria() {
            objManagerBD = new ManagerBD();
        }
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
