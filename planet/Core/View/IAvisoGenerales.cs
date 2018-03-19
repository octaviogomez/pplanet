using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;
namespace Core.View
{
    public interface IAvisoGenerales
    {
        void MensajeAvisoGenerales(string Mensaje, int tipo);

        CAvisoGenerales ObjAvisoGenerales { set; get; }
        DataSet AvisoGeneralesDt { set; get; }

    }
}
