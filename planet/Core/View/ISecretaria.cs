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
        void MensajeSecretaria(string Mensaje, int tipo);

        CSecretaria ObjSecretaria { set; get; }
        CSecretaria ObjSecretariaAux { set; get; }
        DataSet SecretariaDt { set; get; }

    }
}
