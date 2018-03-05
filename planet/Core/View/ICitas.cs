using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface ICitas
    {
        void Mensaje(string Mensaje, int tipo);

        CCitas ObjetoCitas{ set; get; }
        CClubs ObjetoCitasAux { set; get; }
        DataSet ListadoDt { set; get; }
        DataSet ListadoEsp { set; get; }
    }
}
