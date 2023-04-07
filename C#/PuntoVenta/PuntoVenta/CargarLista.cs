using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace PuntoVenta
{
    public class CargarLista
    {
        public static List<Articulo> _listaArticulos = new List<Articulo>();

        public static List<Articulo> CargarList()
        {

            string archivoArticulos = @"C:\Users\Tichs\Desktop\FRANCISCO\Github\PracticasTich\PuntoVenta\PuntoVenta\bin\Debug\Articulos.json";
            StreamReader jsonArticulos = new StreamReader(archivoArticulos);
            string json = jsonArticulos.ReadToEnd();
            jsonArticulos.Close();
            return _listaArticulos = JsonConvert.DeserializeObject<List<Articulo>>(json);
        }

    }
}
