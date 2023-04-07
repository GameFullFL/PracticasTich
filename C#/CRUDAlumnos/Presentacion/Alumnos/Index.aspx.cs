using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        NAlumno capaNAlumno = new NAlumno();
        NEstado capaNEstado = new NEstado();
        NEstatusAlumno capaNEstatus = new NEstatusAlumno();
        Alumno alumno = new Alumno();
        NEstado estado = new NEstado();
        NEstatusAlumno estatusAlumno = new NEstatusAlumno();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();
            }
        }

        protected void gVListaAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Page")
            {
                return;
            }
            int numRenglon = Convert.ToInt32(e.CommandArgument);
            GridViewRow renglon = gVListaAlumnos.Rows[numRenglon];
            TableCell celda = renglon.Cells[0];
            int id = Convert.ToInt32(celda.Text);
            switch (e.CommandName)
            {
                case "btnDetalles":
                    Response.Redirect($"Details.aspx?id={id}");
                    break;
                case "btnEditar":
                    Response.Redirect($"Edit.aspx?id={id}");
                    break;
                case "btnEliminar":
                    Response.Redirect($"Delete.aspx?id={id}");
                    break;

            }
        }

        protected void gVListaAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gVListaAlumnos.PageIndex = e.NewPageIndex;
            cargarGrid();
        }
        private void cargarGrid()
        {
            List<Alumno> listAlumno = capaNAlumno.Consultar();
            List<Estado> listEstado = capaNEstado.Consultar();
            List<EstatusAlumno> listEstatus = capaNEstatus.Consultar();
            var innerConsulta = from alumno in listAlumno
                                 join estado in listEstado on
                                 alumno.idEstadoOrigen equals estado.id
                                 join estatusAlumno in
                                 listEstatus on alumno.idEstatus equals estatusAlumno.id
                                 select new
                                 {  alumno.id, nombre = alumno.nombre, alumno.primerApellido,
                                     alumno.segundoApellido, alumno.correo, alumno.telefono,
                                     idEstadoOrigen = estado.nombre, idEstatus = estatusAlumno.nombre };


            gVListaAlumnos.DataSource = innerConsulta.ToList();
            gVListaAlumnos.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx");
        }
    }
}