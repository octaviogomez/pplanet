using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Core.Model;

namespace Core.View
{
    public interface ISecretaria
    {
        void Mensaje(string Mensaje, int tipo);

        CSecretaria UsuarioLogeado { set; get; }
        CSecretaria UsuarioActulizar { set; get; }
        DataSet UsuariosDt { set; get; }

    }
}
