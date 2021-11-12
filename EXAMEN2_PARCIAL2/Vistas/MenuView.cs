using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXAMEN2_PARCIAL2.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
       
        ClienteView vistaClientes;
        
      

      
        private void ClientesToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (vistaClientes == null)
            {
                vistaClientes = new ClienteView();
                //vistaClientes.MdiParent = this;
                vistaClientes.FormClosed += VistaClientes_FormClosed; ;
                vistaClientes.Show();
            }
            else
            {
                vistaClientes.Activate();
            }

        }


  private void VistaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaClientes = null;
        }

    }
}
