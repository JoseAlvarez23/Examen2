using EXAMEN2_PARCIAL2.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN2_PARCIAL2.Vistas
{
    public partial class EstadoTicketsViewcs : Form
    {
        public EstadoTicketsViewcs()
        {
            InitializeComponent();
            EstadoController controlador = new EstadoController(this);
        }
    }
}
