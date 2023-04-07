using Entidades;
using Negocio;
using System.Web.Services;


namespace webServiceASMXEjemplo
{
    /// <summary>
    /// Descripción breve de WSAlumnos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WSAlumnos : System.Web.Services.WebService
    {

        [WebMethod]
        public AportacionesIMSS CalcularIMSS(int id)
        {
            NAlumno nalumno = new NAlumno();
            AportacionesIMSS aportaciones = nalumno.CalcularIMSS(id);
            return aportaciones;
        }

        [WebMethod]
        public ItemTablaISR CalcularISR(int id)
        {
            NAlumno alumno = new NAlumno();
            ItemTablaISR alumnoISR = new ItemTablaISR();
            alumnoISR = alumno.CalcularISR(id);
            return alumnoISR;
        }
    }
}
