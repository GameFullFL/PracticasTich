using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;
using Datos;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Configuration;

namespace Negocio
{
    public class NEstatus
    {
        string _urlWebAPi = ConfigurationManager.AppSettings["urlWebApi"];
        List<EstatusAlumnos> _estatus = new List<EstatusAlumnos>();
        EstatusAlumnos estatus = new EstatusAlumnos();

        public NEstatus()
        {
        }

        public List<EstatusAlumnos> Consultar()
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    Task<HttpResponseMessage> tarea = cliente.GetAsync(_urlWebAPi);

                    tarea.Wait();
                    HttpResponseMessage resultado = tarea.Result;
                    if (resultado.IsSuccessStatusCode)
                    {
                        Task<string> leerTarea = resultado.Content.ReadAsStringAsync();
                        leerTarea.Wait();
                        string json = leerTarea.Result;
                        _estatus = JsonConvert.DeserializeObject<List<EstatusAlumnos>>(json);
                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondió con error. {resultado.StatusCode}");
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception($"WebAPI. Respondió con error. {e.Message}");
            }
            return _estatus;    
         }
        public EstatusAlumnos Consultar(int id)
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    Task<HttpResponseMessage> tarea = cliente.GetAsync(_urlWebAPi + $"/{id}");

                    tarea.Wait();
                    HttpResponseMessage resultado = tarea.Result;
                    if (resultado.IsSuccessStatusCode)
                    {
                        Task<string> leerTarea = resultado.Content.ReadAsStringAsync();
                        leerTarea.Wait();
                        string json = leerTarea.Result;
                        estatus = JsonConvert.DeserializeObject<EstatusAlumnos>(json);
                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondió con error. {resultado.StatusCode}");
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondió con erro. {ex.Message}");
            }
            return estatus;
        }
        public EstatusAlumnos Agregar(EstatusAlumnos estatus)
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(estatus), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var postTarea = cliente.PostAsync(_urlWebAPi, httpContent);
                    postTarea.Wait();

                    var resultado = postTarea.Result;
                    if (resultado.IsSuccessStatusCode)
                    {
                        var leerTarea = resultado.Content.ReadAsStringAsync();
                        leerTarea.Wait();
                        string json = leerTarea.Result;
                        estatus = JsonConvert.DeserializeObject<EstatusAlumnos>(json);
                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondió con error. {resultado.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondió con error. {ex.Message}");
            }
            return estatus;
        }

        public void Actualizar(EstatusAlumnos estatus)
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(estatus), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var postTarea = cliente.PutAsync(_urlWebAPi + $"/{estatus.id}", httpContent);
                    postTarea.Wait();

                    var resultado = postTarea.Result;
                    if (!resultado.IsSuccessStatusCode)
                    {
                        throw new Exception($"WebAPI. Respondió con error. {resultado.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"WebAPI. Respondió con error. {ex.Message}");
            }

        }

        public void Eliminar(int id)
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    Task<HttpResponseMessage> tarea = cliente.DeleteAsync(_urlWebAPi + $"/{id}");

                    tarea.Wait();
                    HttpResponseMessage resultado = tarea.Result;
                    if (!resultado.IsSuccessStatusCode)
                    {
                        throw new Exception($"WebAPI. Respondió con error. {resultado.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondió con error. {ex.Message}");
            }

        }

    }
}
