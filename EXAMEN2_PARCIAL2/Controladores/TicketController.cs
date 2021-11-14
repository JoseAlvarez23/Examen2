using EXAMEN2_PARCIAL2.Modelos.DAO;
using EXAMEN2_PARCIAL2.Modelos.Entidades;
using EXAMEN2_PARCIAL2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN2_PARCIAL2.Controladores
{
    public class TicketController
    {
        TicketsView vista;
        TicketDAO ticketDAO = new TicketDAO();
        Tickets tickets = new Tickets();
        string operacion = string.Empty;

        public TicketController(TicketsView view)
        {
            vista = view;
            vista.btn_nuevoticket.Click += new EventHandler(Nuevo);
            vista.btn_guadarticket.Click += new EventHandler(Guardar);
            vista.btn_modificarticket.Click += new EventHandler(Modificar);
            vista.btn_eliminarticket.Click += new EventHandler(Eliminar);
            vista.btn_cancelarticket.Click += new EventHandler(Cancelar);
        }
        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            tickets = null;
        }
        private void Eliminar(object sender, EventArgs e)
        {
         
        }

        private void Modificar(object sender, EventArgs e)
        {
         
        }
      

      
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_nombreticket.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombreticket, "Por favor ingrese un Nombre");
                vista.txt_nombreticket.Focus();
                return;
            }

            if (vista.txt_numeroticket.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_numeroticket, "Por favor ingrese el numero de su ticket");
                vista.txt_numeroticket.Focus();
                return;
            }
        
            if (vista.txt_asunto.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_asunto, "Por favor ingrese el asunto de su ticket");
                vista.txt_asunto.Focus();
                return;
            }


            try
            {
                tickets.Nombre = vista.txt_nombreticket.Text;
                tickets.Numero = vista.txt_numeroticket.Text;
                tickets.Asunto = vista.txt_asunto.Text;


                if (operacion == "Nuevo")
                {
                    bool inserto = ticketDAO.InsertarNuevoTickets(tickets);
                    if (inserto)
                    {
                        MessageBox.Show("Ticket generaddo exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar el ticket, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    tickets.Id = Convert.ToInt32(vista.txt_idticket.Text);
                    bool modifico = ticketDAO.ActualizarTicket(tickets);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Usuario Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Modificar el usuario. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }

        }


        private void HabilitarControles()
        {
            //Habilitar TextBoxs
            vista.txt_nombreticket.Enabled = true;
            vista.txt_numeroticket.Enabled = true;
            vista.txt_asunto.Enabled = true;


            //Habilitar Botones
            vista.btn_guadarticket.Enabled = true;
            vista.btn_cancelarticket.Enabled = true;
            vista.btn_eliminarticket.Enabled = true;
            vista.btn_modificarticket.Enabled = false;
            vista.btn_nuevoticket.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_idticket.Enabled = false;
            vista.txt_nombreticket.Enabled = false;
            vista.txt_numeroticket.Enabled = false;
            vista.txt_asunto.Enabled = false;


            //Habilitar y desahiblitar Botones
            vista.btn_guadarticket.Enabled = false;
            vista.btn_cancelarticket.Enabled = false;
            vista.btn_modificarticket.Enabled = true;
            vista.btn_nuevoticket.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_idticket.Clear();
            vista.txt_nombreticket.Clear();
            vista.txt_numeroticket.Clear();
            vista.txt_asunto.Clear();

        }
    }
}
