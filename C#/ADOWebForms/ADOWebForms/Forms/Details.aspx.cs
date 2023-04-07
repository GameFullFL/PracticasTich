using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            string nombre = Request.QueryString["nombre"];
            string clave = Request.QueryString["clave"];
            lblIdValor.Text = id.ToString();
            lblNombreValor.Text = nombre.ToString();
            lblClaveValor.Text = clave.ToString();
        }
    }
}