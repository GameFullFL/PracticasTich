using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LINQ
{
    internal class OperacionesLINQ
    {
        public (List<Alumno>, List<Estado>, List<Estatus>, List<ItemISR>) CargarLists()

        {
            // Cargar Alumnos.json
            string alumnosJson = File.ReadAllText("Alumnos.json");
            List<Alumno> alumnos = JsonConvert.DeserializeObject<List<Alumno>>(alumnosJson);

            // Cargar Estados.json
            string estadosJson = File.ReadAllText("Estados.json");
            List<Estado> estados = JsonConvert.DeserializeObject<List<Estado>>(estadosJson);

            // Cargar Estatus.json
            string estatusJson = File.ReadAllText("Estatus.json");
            List<Estatus> estatus = JsonConvert.DeserializeObject<List<Estatus>>(estatusJson);

            // Cargar TablaISR.csv
            List<ItemISR> tablaISR = new List<ItemISR>();
            string[] lines = File.ReadAllLines("TablaISR.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                tablaISR.Add(new ItemISR
                {
                    LimInf = decimal.Parse(values[0]),
                    LimSup = decimal.Parse(values[1]),
                    CuotaFija = decimal.Parse(values[2]),
                    PorExced = decimal.Parse(values[3]),
                    Subsidio = decimal.Parse(values[4])
                });
            }
            return (alumnos, estados, estatus, tablaISR);
        }
        public void Consulta1(List<Alumno> alumnos, List<Estado> estados)
        {
            // 7.2.1.1.
            var estadoId5 = estados.FirstOrDefault(e => e.idE == 5);
            Console.WriteLine($"7.2.1.1: Estado con Id = 5: {estadoId5.nombreE}");
        }
        public void Consulta2(List<Alumno> alumnos)
        {
            // 7.2.1.2.
            var alumnosIdEstado29Y13 = alumnos.Where(a => a.idEstado == 29 || a.idEstado == 13).OrderBy(a => a.nombreA).ToList();
            Console.WriteLine("7.2.1.2: Alumnos con IdEstado 29 y 13, ordenados por nombre:");
            foreach (var alumno in alumnosIdEstado29Y13)
            {
                Console.WriteLine($"Id: {alumno.idA}, Nombre: {alumno.nombreA}, IdEstado: {alumno.idEstado}");
            }
        }
        public void Consulta3(List<Alumno> alumnos)
        {
            // 7.2.1.3.
            var alumnosIdEstado19Y20Estatus4Y5 = alumnos.Where(a => (a.idEstado == 19 || a.idEstado == 20) && (a.idEstatus == 4 || a.idEstatus == 5)).ToList();
            Console.WriteLine("7.2.1.3: Alumnos con IdEstado 19 y 20 y con Estatus 4 y 5:");
            foreach (var alumno in alumnosIdEstado19Y20Estatus4Y5)
            {
                Console.WriteLine($"Id: {alumno.idA}, Nombre: {alumno.nombreA}, IdEstado: {alumno.idEstado}, IdEstatus: {alumno.idEstatus}");
            }
        }

        public void Consulta4(List<Alumno> alumnos)
        {
            // 7.2.1.4.
            var alumnosAprobados = alumnos.Where(a => a.Calificacion >= 6).OrderByDescending(a => a.Calificacion).ToList();
            Console.WriteLine("7.2.1.4: Alumnos con calificación aprobatoria, ordenados de mayor a menor:");
            foreach (var alumno in alumnosAprobados)
            {
                Console.WriteLine($"Id: {alumno.idA}, Nombre: {alumno.nombreA}, Calificación: {alumno.Calificacion}");
            }
        }

        public void Consulta5(List<Alumno> alumnos)
        {
            // 7.2.1.5.
            var promedio = alumnos.Average(a => a.Calificacion);
            Console.WriteLine($"7.2.1.5: Calificación promedio de los alumnos: {promedio}");
        }

        public void Consulta6(List<Alumno> alumnos)
        {
            // 7.2.1.6.
            bool ningunAlumnoCon10 = !alumnos.Any(a => a.Calificacion == 10);
            bool todosAlumnosEntre6Y7 = alumnos.All(a => a.Calificacion >= 6 && a.Calificacion <= 7);
            if (ningunAlumnoCon10)
            {
                alumnos.ForEach(a => a.Calificacion++);
            }
            else if (todosAlumnosEntre6Y7)
            {
                alumnos.ForEach(a => a.Calificacion += 2);
            }
        }

        public void Consulta7(List<Alumno> alumnos, List<Estado> estados)
        {
            // 7.2.1.7.
            var alumnosEstatus3 = alumnos.Where(a => a.idEstatus == 3).ToList();
            Console.WriteLine("7.2.1.7: Alumnos en Estatus 3:");
            foreach (var alumno in alumnosEstatus3)
            {
                var estado = estados.FirstOrDefault(e => e.idE == alumno.idEstado);
                Console.WriteLine($"IdAlumno: {alumno.idA}, NombreAlumno: {alumno.nombreA}, NombreEstado: {estado.nombreE}");
            }
        }

        public void Consulta8(List<Alumno> alumnos, List<Estatus> estatus)
        {
            // 7.2.1.8.
            var alumnosEstatus2 = alumnos.Where(a => a.idEstatus == 2).OrderBy(a => a.nombreA).ToList();
            Console.WriteLine("7.2.1.8: Alumnos en Estatus 2, ordenados por nombre:");
            foreach (var alumno in alumnosEstatus2)
            {
                var est = estatus.FirstOrDefault(es => es.idEs == alumno.idEstatus);
                Console.WriteLine($"IdAlumno: {alumno.idA}, NombreAlumno: {alumno.nombreA}, NombreEstatus: {est.nombreEs}");
            }
        }
        public void Consulta9(List<Alumno> alumnos, List<Estado> estados, List<Estatus> estatus)
        {
            // 7.2.1.9.
            var alumnosEstatusMayor2 = alumnos.Where(a => a.idEstatus > 2).OrderBy(a => a.idEstatus).ThenBy(a => a.nombreA).ToList();
            Console.WriteLine("7.2.1.9: Alumnos con Estatus mayor a 2, ordenados por nombre de Estatus y Nombre:");

            foreach (var alumno in alumnosEstatusMayor2)
            {
                var estado = estados.FirstOrDefault(e => e.idE == alumno.idEstado);
                var est = estatus.FirstOrDefault(es => es.idEs == alumno.idEstatus);
                Console.WriteLine($"IdAlumno: {alumno.idA}, NombreAlumno: {alumno.nombreA}, NombreEstado: {estado.nombreE}, NombreEstatus: {est.nombreEs}");

            }
        }

        public void Consulta10(List<ItemISR> tablaISR, decimal sueldoMensual)
        {
            // 7.2.1.10.
            var isr = tablaISR.FirstOrDefault(t => t.LimInf <= sueldoMensual && t.LimSup >= sueldoMensual);
            if (isr != null)
            {
                decimal divi = isr.PorExced / 100;
                decimal isrCalculado = isr.CuotaFija + ((sueldoMensual - isr.LimInf) * divi);
                Console.WriteLine($"7.2.1.10: ISR para sueldo mensual de {sueldoMensual}: {isrCalculado}");
            }
            else
            {
                Console.WriteLine("7.2.1.10: No se encontró un registro de ISR para el sueldo mensual proporcionado.");
            }
        }
    }
}
