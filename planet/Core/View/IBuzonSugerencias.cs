using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;


namespace Core.View
{
    public interface IBuzonSugerencias
    {
        void Mensaje(string Mensaje, int tipo);

        CBuzonSugerencias ObjBuzonSugerencias { set; get; }
        DataSet CBuzonSugerenciasDt { set; get; }
    }
}
