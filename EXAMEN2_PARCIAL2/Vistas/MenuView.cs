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
        DetallesTicketsView vistaDetalles;
        SoporteView vistaSoporte;
        EstadoTicketsViewcs vistaEstado;
        TicketsView vistaTickets;
      

      
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

       

        private void SoportetoolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaSoporte == null)
            {
                vistaSoporte = new SoporteView();
                //vistaSoporte.MdiParent = this;
                vistaSoporte.FormClosed += vistaSoporte_FormClosed; ;
                vistaSoporte.Show();
            }
            else
            {
                vistaSoporte.Activate();
            }
        }

        private void vistaSoporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaSoporte = null;
        }

        private void EstadotoolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaEstado == null)
            {
                vistaEstado = new EstadoTicketsViewcs();
                //vistaEstado.MdiParent = this;
                vistaEstado.FormClosed += vistaEstado_FormClosed; ;
                vistaEstado.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
        }

        private void vistaEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaEstado = null;
        }


        private void TicketstoolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTickets == null)
            {
                vistaTickets = new TicketsView();
                //vistaTickets.MdiParent = this;
                vistaTickets.FormClosed += vistaTickets_FormClosed; ;
                vistaTickets.Show();
            }
            else
            {
                vistaTickets.Activate();
            }
        }

        private void vistaTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTickets = null;
        }

        private void DetallestoolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaDetalles == null)
            {
                vistaDetalles = new DetallesTicketsView();
                //vistaDetalles.MdiParent = this;
                vistaDetalles.FormClosed += vistaDetalles_FormClosed; ;
                vistaDetalles.Show();
            }
            else
            {
                vistaDetalles.Activate();
            }
        }

        private void vistaDetalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaDetalles = null;
        }
        private void toolStripEx2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
