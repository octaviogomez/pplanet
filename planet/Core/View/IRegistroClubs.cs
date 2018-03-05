using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;


namespace Core.View
{
    public interface IRegistroClubs
    {
        void Mensaje(string Mensaje, int tipo);

        CRegistroClubs ObjRegistroClubs { set; get; }
        CRegistroClubs ObjRegistroClubsAux { set; get; }
        DataSet ListadoDt { set; get; }
        DataSet ListadoDtAux { set; get; }
    }
}
