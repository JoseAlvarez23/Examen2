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
    public class SoporteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoSoporte(Soporte soporte)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO SOPORTE ");
                sql.Append(" VALUES (@Dispositivo, @Tiposoporte); ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Dispositivo", SqlDbType.NVarChar, 50).Value = soporte.Dispositivo;
                comando.Parameters.Add("@Tiposoporte", SqlDbType.NVarChar, 80).Value = soporte.Tiposoporte;
                

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
        public DataTable GetSoporte()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM SOPORTE ");
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
        public bool ActualizarSoporte(Soporte soporte)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE SOPORTE ");
                sql.Append(" SET DISPOSITIVO = @Dispositivo, TIPOSOPORTE = @Tiposoporte ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = soporte.Id;
                comando.Parameters.Add("@Dispositivo", SqlDbType.NVarChar, 50).Value = soporte.Dispositivo;
                comando.Parameters.Add("@Tiposoporte", SqlDbType.NVarChar, 80).Value = soporte.Tiposoporte;
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
        public bool EliminarSoporte(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM SOPORTE ");
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
