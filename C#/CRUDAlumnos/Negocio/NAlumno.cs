using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;
using Newtonsoft.Json;


namespace Negocio
{
    public class NAlumno
    {
        Datos.DAlumno alumno = new Datos.DAlumno();
        ItemTablaISR itemTablaISR = new ItemTablaISR();
        Alumno alumnos = new Alumno();
        AportacionesIMSS aportaciones = new AportacionesIMSS();

        public List<Alumno> Consultar()=>alumno.Consultar();
        public Entidades.Alumno Consultar(int id)=>alumno.Consultar(id);    
        public void Agregar(Alumno alumnop)=>alumno.Agregar(alumnop);
        public void Actualizar(Alumno alumnopa)=>alumno.Actualizar(alumnopa);
        public void eliminar(int id)=>alumno.eliminar(id);
        public List<ItemTablaISR> ConsultarTablaISR()=>alumno.ConsultarTablaISR();

        public ItemTablaISR CalcularISR(int id)
        {
            /*
            Negocio.AlumnosService.WSAlumnosSoapClient wSAlumnosSoapClient = new AlumnosService.WSAlumnosSoapClient();
            try
            {
                AlumnosService.ItemTablaISR des = wSAlumnosSoapClient.CalcularISR(id);
                string dese = JsonConvert.SerializeObject(des);
                itemTablaISR = JsonConvert.DeserializeObject<ItemTablaISR>(dese);
            }
            catch
            {*/
                alumnos = alumno.Consultar(id);
                decimal sueldo = alumnos.sueldo;
                List<ItemTablaISR> tabla = ConsultarTablaISR();
                decimal quincena = sueldo / 2;
                decimal isrQuincenal = 0;
                decimal isrimpuesto = 0;
                itemTablaISR = tabla.Find(x => quincena >= x.LimiteInferior && quincena <= x.LimiteSuperior);
                isrQuincenal = (quincena - itemTablaISR.LimiteInferior) * (itemTablaISR.Excedente / 100);
                isrimpuesto = (isrQuincenal + itemTablaISR.CuotaFija) - itemTablaISR.Subsidio;
                itemTablaISR.ISR = isrimpuesto;
            //}
            return itemTablaISR;

        }

        public AportacionesIMSS CalcularIMSS(int id)
        {

            decimal uma = Convert.ToDecimal(ConfigurationManager.AppSettings["UMA"]);
            alumnos = alumno.Consultar(id);
            aportaciones.EnfermedadMaternidad = (alumnos.sueldo - (3 * uma)) * 0.004m;
            aportaciones.InvalidezVida = alumnos.sueldo * 0.00625m;
            aportaciones.Retiro = alumnos.sueldo * 0;
            aportaciones.Cesantía = alumnos.sueldo * 0.01125m;
            aportaciones.Infonavit = alumnos.sueldo * 0;
            return aportaciones;
        }

    }
    }

