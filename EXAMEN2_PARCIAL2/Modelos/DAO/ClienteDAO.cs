using EXAMEN2_PARCIAL2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2_PARCIAL2.Modelos.DAO
{
    public class ClienteDAO : Conexion
    {

        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoCliente(Cliente cliente)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE ");
                sql.Append(" VALUES (@Identidad, @Nombre, @Email); ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                
                comando.ExecuteNonQuery();
                inserto = true;
                ConexionExamen.Close();
                //return true;
            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }
        public DataTable GetCliente()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTE ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                ConexionExamen.Close();
            }
            catch (Exception)
            {


            }
            return dt;
        }
        public bool ActualizarCliente(Cliente cliente)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTE ");
                sql.Append(" SET IDENTIDAD = @Identidad, NOMBRE = @Nombre, EMAIL = @Email ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = cliente.Id;
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.ExecuteNonQuery();
                modifico = true;
                ConexionExamen.Close();

            }
            catch (Exception)
            {

                return modifico;
            }
            return modifico;
        }
        public bool EliminarCliente(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                elimino = true;
                ConexionExamen.Close();

            }
            catch (Exception)
            {

                return elimino;
            }
            return elimino;
        }
    }
}
