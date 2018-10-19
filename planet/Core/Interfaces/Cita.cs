using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface Cita
    {
        #region Propiedaes
         int pk_cita { get; set; }
         int estado { get; set; }
         string fecha { get; set; }
         int fk_hora { get; set; }
         int cupo { get; set; }
         int id_registro { get; set; }
        #endregion
    }
}
