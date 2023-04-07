using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Index : System.Web.UI.Page
    {
        ADO.ADOEstatusAlumno estatus = new ADO.ADOEstatusAlumno();
        Entidades.EstatusAlumno estatusAlu = new Entidades.EstatusAlumno();
        List<Entidades.EstatusAlumno> EstatusAlumnoList = new List<Entidades.EstatusAlumno>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                inicio();
            }
            
        }

        public void inicio()
        {
            EstatusAlumnoList = estatus.Consultar();
            cmbEstatusAlumnos.DataSource = EstatusAlumnoList;
            cmbEstatusAlumnos.DataTextField = "nombre";
            cmbEstatusAlumnos.DataValueField = "id";
            cmbEstatusAlumnos.DataBind(); 
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            EstatusAlumnoList = estatus.Consultar();
            int id = Convert.ToInt16(cmbEstatusAlumnos.SelectedItem.Value);
            string clave = EstatusAlumnoList.FirstOrDefault(c => c.id == id)?.clave;
            string nombre = cmbEstatusAlumnos.SelectedItem.Text;
            Response.Redirect($"Details.aspx?id={id}&clave={clave}&nombre={nombre}");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx?");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Edit.aspx?");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EstatusAlumnoList = estatus.Consultar();
            int id = Convert.ToInt16(cmbEstatusAlumnos.SelectedItem.Value);
            string clave = EstatusAlumnoList.FirstOrDefault(c => c.id == id)?.clave;
            string nombre = cmbEstatusAlumnos.SelectedItem.Text;
            Response.Redirect($"Delete.aspx?id={id}&clave={clave}&nombre={nombre}");
        }
    }
}