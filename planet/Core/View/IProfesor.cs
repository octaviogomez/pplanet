using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Model;
namespace Core.View
{
    public interface IProfesor
    {
        void Mensaje(string Mensaje, int tipo);

        CProfesor UsuarioLogeado { set; get; }
        CProfesor UsuarioActulizar { set; get; }
        DataSet UsuariosDt { set; get; }
    }
}
