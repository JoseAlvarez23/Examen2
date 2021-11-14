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
    public class TicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoTickets(Tickets tickets)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@Nombre, @Numero, @Asunto); ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = tickets.Nombre;
                comando.Parameters.Add("@Numero", SqlDbType.NVarChar, 50).Value = tickets.Numero;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 80).Value = tickets.Asunto;

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
        public DataTable GetTickets()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET ");
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
        public bool ActualizarTicket(Tickets tickets)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TICKET ");
                sql.Append(" SET  NOMBRE = @Nombre, NUMERO = @Numero, ASUNTO = @Asunto ");
                sql.Append(" WHERE ID = @Id; ");
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tickets.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = tickets.Nombre;
                comando.Parameters.Add("@Numero", SqlDbType.NVarChar, 50).Value = tickets.Numero;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 80).Value = tickets.Asunto;
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
        public bool EliminarTicket(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TICKET ");
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
