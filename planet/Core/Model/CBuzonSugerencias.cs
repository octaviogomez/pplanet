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
    public class CBuzonSugerencias
    {
        ManagerBD objManagerBD;
        public CBuzonSugerencias()
        {
            objManagerBD = new ManagerBD();
        }
        #region Propiedades
       
        public int pk_buzonSugerencia { get; set; }
        public int fk_alumno { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string descripcion { get; set; }

        #endregion
    }
}
