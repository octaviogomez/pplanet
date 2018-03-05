using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Core.Model;
namespace Core.View
{
    public interface ICat_TipoCitas
    {
        void Mensaje(string Mensaje, int tipo);

        CCat_TipoCitas ObjCat_TipoCitas { set; get; }
        DataSet TipoCitasDt { set; get; }
    }
}
