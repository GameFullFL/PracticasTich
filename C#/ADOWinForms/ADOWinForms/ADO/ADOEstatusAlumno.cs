using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;


namespace ADOWinForms.ADO
{
    public class ADOEstatusAlumno : ADO.ICRUD
    {
        string Conexion = ConfigurationManager.ConnectionStrings["InstitutoConnection"].ConnectionString;
        List<Entidades.EstatusAlumno> lstEstatus;
        string consulta;
        SqlCommand comando = new SqlCommand();

        public List<Entidades.EstatusAlumno> Consultar()
        {
            consulta = $"select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                lstEstatus = new List<Entidades.EstatusAlumno>();
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstEstatus.Add(
                        new Entidades.EstatusAlumno()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            clave = reader["clave"].ToString(),
                            nombre = reader["nombre"].ToString(),
                        }
                        );
                }
                con.Close();
                return lstEstatus;
            }

        }

        public Entidades.EstatusAlumno Consultar(int id)
        {
            Entidades.EstatusAlumno estatus = new Entidades.EstatusAlumno();
            consulta = $"select * from EstatusAlumnos where id={id}";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estatus =
                         new Entidades.EstatusAlumno()
                         {
                             id = Convert.ToInt32(reader["id"]),
                             clave = reader["clave"].ToString(),
                             nombre = reader["nombre"].ToString(),
                         };

                }
                con.Close();
                return estatus;
            }

        }

        public int Agregar(Entidades.EstatusAlumno estatus)
        {
            consulta = $" INSERT EstatusAlumnos ([clave], [nombre]) " +
                          $"VALUES (N'{estatus.clave}', N'{estatus.nombre}')";
            using (SqlConnection conexion = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            return 0;
        }

        public void Actualizar(Entidades.EstatusAlumno estatus)
        {
            consulta = $"update EstatusAlumnos set clave ='{estatus.clave}',nombre='{estatus.nombre}' where id='{estatus.id}'";
            using (SqlConnection conexion = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void Eliminar(int id)
        {
            consulta = $"delete EstatusAlumnos where id={id}";
            using (SqlConnection conexion = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }

    }
}
