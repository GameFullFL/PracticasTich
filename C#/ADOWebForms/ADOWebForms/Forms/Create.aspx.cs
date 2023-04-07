using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Create : System.Web.UI.Page
    {
        ADO.ADOEstatusAlumno estatus = new ADO.ADOEstatusAlumno();
        Entidades.EstatusAlumno estatusAlu = new Entidades.EstatusAlumno();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            estatusAlu.clave = txtClave.Text.ToUpper().Trim();
            estatusAlu.nombre = txtNombre.Text;
            estatus.Agregar(estatusAlu);
            Response.Redirect($"Index.aspx?");
        }
    }
}