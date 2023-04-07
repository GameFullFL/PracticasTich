using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Negocio;
using Newtonsoft.Json;

namespace WCFAlumnos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFAlumnos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFAlumnos.svc o WCFAlumnos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFAlumnos : IWCFAlumnos
    {
        NAlumno _alumno = new NAlumno(); 
        public AportacionesIMSS CalcularIMSS(int id)
        {
            Entidades.AportacionesIMSS alumnoImss = _alumno.CalcularIMSS(id);
            string alumnoJson = JsonConvert.SerializeObject(alumnoImss);
            AportacionesIMSS wcfAlumnoImss = JsonConvert.DeserializeObject<AportacionesIMSS>(alumnoJson);
            return wcfAlumnoImss;
        }

        public ItemTablaISR CalcularItemISR(int id)
        {
            Entidades.ItemTablaISR tablaISR = _alumno.CalcularISR(id);
            string isrJson = JsonConvert.SerializeObject(tablaISR);
            ItemTablaISR wcfTablaIsr = JsonConvert.DeserializeObject<ItemTablaISR>(isrJson);
            return wcfTablaIsr;
        }
    }
}
