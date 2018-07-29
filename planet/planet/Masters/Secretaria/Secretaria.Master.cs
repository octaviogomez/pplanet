using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Core.Model;
namespace planet.Masters.Secretaria
{
    public partial class Secretaria : System.Web.UI.MasterPage
    {
        CSecretaria objSecretaria;
        protected void Page_Load(object sender, EventArgs e)
        {
            objSecretaria = (CSecretaria)Session["SecretariaSesion"];
            if (objSecretaria!=null && objSecretaria.rol==3  && objSecretaria.activo==1)
            {

            }
            else
            {
                Response.Redirect("../../Default.aspx", true);//
            }
        }
    }
}