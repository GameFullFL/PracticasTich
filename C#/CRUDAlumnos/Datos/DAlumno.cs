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
    public class DAlumno
    {
        string Conexion = ConfigurationManager.ConnectionStrings["InstitutoConnection"].ConnectionString;
        List<Entidades.Alumno> lstAlumno;
        string consulta;
        List<ItemTablaISR> lstTablaISR;

        SqlCommand comando = new SqlCommand();
        public List<Entidades.Alumno> Consultar()
        {
            consulta = $"consultarAlumnos";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                lstAlumno = new List<Entidades.Alumno>();
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstAlumno.Add(
                        new Entidades.Alumno()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                            primerApellido = reader["primerApellido"].ToString(),
                            segundoApellido = reader["segundoApellido"].ToString(),
                            correo = reader["correo"].ToString(),
                            telefono = reader["telefono"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                            curp = reader["curp"].ToString(),
                            sueldo = Convert.ToDecimal(reader["sueldo"]),
                            idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"]),
                            idEstatus = Convert.ToInt32(reader["idEstatus"]),
                        }
                        );
                }
                con.Close();
                return lstAlumno;
            }

        }

        public Entidades.Alumno Consultar(int id)
        {
            Entidades.Alumno alumno = new Entidades.Alumno();
            consulta = $"consultarAlumnos";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    alumno =
                         new Entidades.Alumno()
                         {
                             id = Convert.ToInt32(reader["id"]),
                             nombre = reader["nombre"].ToString(),
                             primerApellido = reader["primerApellido"].ToString(),
                             segundoApellido = reader["segundoApellido"].ToString(),
                             correo = reader["correo"].ToString(),
                             telefono = reader["telefono"].ToString(),
                             fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                             curp = reader["curp"].ToString(),
                             sueldo = Convert.ToDecimal(reader["sueldo"]),
                             idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"]),
                             idEstatus = Convert.ToInt32(reader["idEstatus"]),
                         };
                }
                con.Close();
                return alumno;
            }
        }

        public void Agregar(Entidades.Alumno alumno)
        {
            //consulta = $" INSERT Alumnos ([id], [nombre], [primerApellido], [segundoApellido], [correo], [telefono], [fechaNacimiento], [curp], [sueldo], [idEstadoOrigen],[idEstatus]) " +
            //  $"VALUES (N'{alumno.id}', N'{alumno.nombre}', N'{alumno.primerApellido}', N'{alumno.segundoApellido}', N'{alumno.correo}', N'{alumno.telefono}', N'{alumno.fechaNacimiento}', N'{alumno.curp}', N'{alumno.sueldo}', N'{alumno.idEstadoOrigen}', N'{alumno.idEstatus}')";
            consulta = $"agregarAlumnos";
            using (SqlConnection conexion = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@apePat", alumno.primerApellido);
                comando.Parameters.AddWithValue("@apeMat", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@idEstado", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", alumno.idEstatus);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

        }

        public void Actualizar(Entidades.Alumno alumno)
        {
            //consulta = $"update Alumnos set nombre='{alumno.nombre}',primerApellido='{alumno.primerApellido}',segundoApellido='{alumno.segundoApellido}',correo='{alumno.correo}',telefono='{alumno.telefono}',fechaNacimiento='{alumno.fechaNacimiento}',curp='{alumno.curp}',sueldo='{alumno.sueldo}',idEstadoOrigen='{alumno.idEstadoOrigen}',idEstatus='{alumno.idEstatus}' where id='{alumno.id}'";
            consulta = $"actualizarAlumnos";
            using (SqlConnection conexion = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", alumno.id);
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@apePat", alumno.primerApellido);
                comando.Parameters.AddWithValue("@apeMat", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@idEstado", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", alumno.idEstatus);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void eliminar(int id)
        {
            //consulta = $"delete Alumnos where id={id}";
            consulta = $"eliminarAlumnos";
            using (SqlConnection conexion = new SqlConnection(Conexion))
            {
                comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", id);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

        }
        public List<ItemTablaISR> ConsultarTablaISR()
        {
            consulta = $"select * from TablaISR";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                lstTablaISR = new List<ItemTablaISR>();
                comando = new SqlCommand(consulta, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstTablaISR.Add(
                        new ItemTablaISR()
                        {
                            LimiteInferior = Convert.ToDecimal(reader["LimInf"]),
                            LimiteSuperior = Convert.ToDecimal(reader["LimSup"]),
                            CuotaFija = Convert.ToDecimal(reader["CuotaFija"]),
                            Excedente = Convert.ToDecimal(reader["ExedLimInf"]),
                            Subsidio = Convert.ToDecimal(reader["Subsidio"]),
                        }
                        );
                }
                con.Close();
                return lstTablaISR;

            }

        }
    }
}
