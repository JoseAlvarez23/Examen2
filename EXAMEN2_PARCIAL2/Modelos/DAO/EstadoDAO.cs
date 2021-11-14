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
   public class EstadoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoEstado(Estado estado)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADO ");
                sql.Append(" VALUES (@Estadoticket); ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Estadoticket", SqlDbType.NVarChar, 50).Value = estado.Estadoticket;



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
        public DataTable GetEstado()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO ");
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
        public bool ActualizarEstado(Estado estado)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADO ");
                sql.Append(" SET ESTADOTICKET = @Estadoticket ");
                sql.Append(" WHERE ID = @Id; ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = estado.Id;
                comando.Parameters.Add("@Estadoticket", SqlDbType.NVarChar, 50).Value = estado.Estadoticket;
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
        public bool EliminarEstado(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADO ");
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
