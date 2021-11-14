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

        public bool InsertarNuevaDetalle(Detalles detalles, List<Tickets> tickets)
        {
            bool inserto = false;

            comando.Connection = ConexionExamen;
            ConexionExamen.Open();

            SqlTransaction transaction = ConexionExamen.BeginTransaction();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO DETALLE ");
                sql.Append(" VALUES ( @IdTicket); ");
                sql.Append(" SELCT SCOPE_IDENTITY() ");

                StringBuilder sqlT = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@Nombre, @Numero, @Asunto); ");

                comando.Transaction = transaction;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdTicket", SqlDbType.Int).Value = detalles.IdTicket;


                int IdDetalle = Convert.ToInt32(comando.ExecuteScalar());

                foreach (var item in tickets)
                {
                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = item.Nombre;
                    comando.Parameters.Add("@Numero", SqlDbType.NVarChar, 50).Value = item.Numero;
                    comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 80).Value = item.Asunto;
                    comando.ExecuteNonQuery();
                }
                transaction.Commit();
                ConexionExamen.Close();
            }
            catch (Exception ex)
            {
                inserto = false;
                transaction.Rollback();
            }
            return inserto;
        }
    }

}
