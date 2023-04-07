using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Alumnos
{
    public partial class Delete : System.Web.UI.Page
    {
        NAlumno alumnoNegocio = new NAlumno();
        Alumno alumno = new Alumno();
        NEstado estado = new NEstado();
        NEstatusAlumno estatusAlumno = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                inicio();
            }
        }

        public void inicio()
        {
            int id = Convert.ToInt32(Request.QueryString["id"] ?? "1");
            alumno = alumnoNegocio.Consultar(id);
            lblId.Text = alumno.id.ToString();
            lblNombre.Text = alumno.nombre.ToString();
            lblApePat.Text = alumno.primerApellido.ToString();
            lblApeMat.Text = alumno.segundoApellido.ToString();
            lblCorreo.Text = alumno.correo.ToString();
            lblFecha.Text = alumno.fechaNacimiento.ToString();
            lblTelefono.Text = alumno.telefono.ToString();
            lblCurp.Text = alumno.curp.ToString();
            lblSueldo.Text = alumno.sueldo.ToString();
            Estado estadoNombre = estado.Consultar(alumno.idEstadoOrigen);
            lblEstado.Text = estadoNombre.nombre;
            EstatusAlumno estatus = estatusAlumno.Consultar(alumno.idEstatus);
            lblEstatus.Text = estatus.nombre;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"] ?? "1");
            alumnoNegocio.eliminar(id);
            Response.Redirect($"Index.aspx?");
        }
    }
}