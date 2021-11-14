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
    public class DetallesDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevaDetalle(Detalles detalles)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO DETALLES");
                sql.Append(" VALUES (@Nombre, @Numero, @Asunto, @Estados); ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = detalles.Nombre;
                comando.Parameters.Add("@Numero", SqlDbType.NVarChar, 50).Value = detalles.Numero;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 80).Value = detalles.Asunto;
                comando.Parameters.Add("@Estados", SqlDbType.NVarChar, 50).Value = detalles.Estados;
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
        public DataTable GetDetalle()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM DETALLES ");
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
        public bool ActualizarDetalle(Detalles detalles)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE DETALLES ");
                sql.Append(" SET  NOMBRE = @Nombre, NUMERO = @Numero, ASUNTO = @Asunto, ESTADOS = @Estados ");
                sql.Append(" WHERE ID = @Id; ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = detalles.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = detalles.Nombre;
                comando.Parameters.Add("@Numero", SqlDbType.NVarChar, 50).Value = detalles.Numero;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 80).Value = detalles.Asunto;
                comando.Parameters.Add("@Estados", SqlDbType.NVarChar, 50).Value = detalles.Estados;
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
        public bool EliminarDetalle(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM DETALLES ");
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
