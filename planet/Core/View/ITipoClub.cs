using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;
namespace Core.View
{
    public interface ITipoClub
    {
        void Mensaje(string Mensaje, int tipo);

        CTipoClub ObjTipoClub { set; get; }
   
        DataSet TipoClubDt { set; get; }
    }
}
