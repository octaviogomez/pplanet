using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;

namespace Core.View
{
    public interface IMensajes
    {
        void Mensaje(string Mensaje, int tipo);

        CMensajes ObjMensajes { set; get; }
        DataSet CMensajesDt { set; get; }
    }
}
