using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;
namespace Core.View
{
    public interface IListaEspera
    {
        void Mensaje(string Mensaje, int tipo);

        CListaEspera ObjListaEspera { set; get; }
      
        DataSet ListaEsperaDt { set; get; }
    }
}
