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
    public class UsuariaoDAO : Conexion
    {

        SqlCommand comando = new SqlCommand();
        //validamos si el usuario esta logiado haciendo uso de un metodo

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIO WHERE EMAIL =@Email AND CLAVE =@Clave;");

                //Ya que arriba pusimos para que heredara de de la clase conexion podemos hacer uso de Miconexion
                comando.Connection = ConexionExamen;
                ConexionExamen.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 80).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = user.Clave;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {


            }
            return valido;
        }

    }



}

