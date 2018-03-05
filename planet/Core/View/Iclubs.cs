using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface Iclubs
    {
        void Mensaje(string Mensaje, int tipo);

        CClubs ObjetoClub { set; get; }
        CClubs ObjetoClubAux { set; get; }
        DataSet ListadoDt { set; get; }
        DataSet ListadoEsp { set; get; }

    }
}
