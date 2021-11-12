using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2_PARCIAL2.Modelos.DAO
{
    public class Conexion
    {
        protected SqlConnection ConexionExamen = new SqlConnection(ConfigurationManager.ConnectionStrings["ExamenConexion"].ConnectionString);
    }
}
