using EXAMEN2_PARCIAL2.Modelos.DAO;
using EXAMEN2_PARCIAL2.Modelos.Entidades;
using EXAMEN2_PARCIAL2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2_PARCIAL2.Controladores
{
    public class EstadoController
    {

        EstadoTicketsViewcs vista;
        EstadoDAO estadoDAO = new EstadoDAO();
        Estado estado = new Estado();
        string operacion = string.Empty;
    }
}
