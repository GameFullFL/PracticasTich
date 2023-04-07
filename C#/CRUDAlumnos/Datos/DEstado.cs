using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class DEstado
    {
        string Conexion = ConfigurationManager.ConnectionStrings["InstitutoConnection"].ConnectionString;
        List<Entidades.Estado> lstEstado;
        string consulta;
        SqlCommand comando = new SqlCommand();
        public List<Entidades.Estado> Consultar()
        {
            consulta = $"consultarEstados";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                lstEstado = new List<Entidades.Estado>();
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstEstado.Add(
                        new Entidades.Estado()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                        }
                        );
                }
                con.Close();
                return lstEstado;
            }

        }
        public Estado Consultar(int id)
        {
            Estado estado = new Estado();
            consulta = $"consultarEstados";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estado = (
                        new Entidades.Estado()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                        }
                        );
                }
                con.Close();
                return estado;
            }

        }

    }
}
