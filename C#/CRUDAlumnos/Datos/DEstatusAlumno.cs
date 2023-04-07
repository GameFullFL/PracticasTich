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
    public class DEstatusAlumno
    {
        string Conexion = ConfigurationManager.ConnectionStrings["InstitutoConnection"].ConnectionString;
        List<Entidades.EstatusAlumno> lstEstatusAlumno;
        string consulta;
        SqlCommand comando = new SqlCommand();
        public List<Entidades.EstatusAlumno> Consultar()
        {
            consulta = $"consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                lstEstatusAlumno = new List<Entidades.EstatusAlumno>();
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstEstatusAlumno.Add(
                        new Entidades.EstatusAlumno()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            clave = reader["clave"].ToString(),
                            nombre = reader["nombre"].ToString(),
                        }
                        );
                }
                con.Close();
                return lstEstatusAlumno;
            }

        }

        public EstatusAlumno Consultar(int id)
        {
            EstatusAlumno estatusAlumno = new EstatusAlumno();
            consulta = $"consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estatusAlumno = (
                        new EstatusAlumno()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            clave = reader["clave"].ToString(),
                            nombre = reader["nombre"].ToString(),
                        }
                        );
                }
                con.Close();
                return estatusAlumno;
            }

        }
    }
}
