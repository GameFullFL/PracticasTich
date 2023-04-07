using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Delete : System.Web.UI.Page
    {
        ADO.ADOEstatusAlumno estatus = new ADO.ADOEstatusAlumno();
        Entidades.EstatusAlumno estatusAlu = new Entidades.EstatusAlumno();
        int id;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt16(Request.QueryString["id"]);
            string nombre = Request.QueryString["nombre"];
            string clave = Request.QueryString["clave"];
            lblIdValor.Text = id.ToString();
            lblNombreValor.Text = nombre.ToString();
            lblClaveValor.Text = clave.ToString();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            estatus.Eliminar(id);
            Response.Redirect($"Index.aspx?");
        }
    }
}