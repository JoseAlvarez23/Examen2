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
    public partial class SoporteView : Form
    {
        public SoporteView()
        {
            InitializeComponent();
            SoporteController controlador = new SoporteController(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
