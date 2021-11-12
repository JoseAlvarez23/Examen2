using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EXAMEN2_PARCIAL2.Modelos.DAO
{
    public class Conexion
    {
        //protected SqlConnection Miconexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ExamenConexion"].ConnectionString);
        protected SqlConnection ConexionExamen = new SqlConnection(ConfigurationManager.ConnectionStrings["ExamenConexion"].ConnectionString);
    }
}
