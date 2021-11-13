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
    public class ClienteController
    {
        ClienteView vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;

        public ClienteController(ClienteView view)
        {
            vista = view;
            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_cancelar.Click += new EventHandler(Cancelar);

        }

        private void Cancelar(object sender, EventArgs e)
        {  
            LimpiarControles();
            cliente = null;
        }
        private void LimpiarControles()
        {
            vista.txt_id.Clear();
            vista.txt_email.Clear();
            vista.txt_identidad.Clear();
            vista.txt_nombre.Clear();  
        }

        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.ClientesDataGridView.DataSource = clienteDAO.GetClientes();
        }

        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            vista.txt_email.Enabled = true;
            vista.txt_identidad.Enabled = true;
            vista.txt_nombre.Enabled = true;
        }

        private void Guardar(object sender, EventArgs e)
        {
            
            if (vista.txt_nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "Ingrese un nombre");
                vista.txt_nombre.Focus();
                return;
            }
            if (vista.txt_identidad.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_identidad, "Ingrese su identidad");
                vista.txt_identidad.Focus();
                return;
            }
            if (vista.txt_email.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Ingrese un email");
                vista.txt_email.Focus();
                return;
            }
            try
            {
                cliente.Identidad = vista.txt_identidad.Text;
                cliente.Nombre = vista.txt_nombre.Text;
                cliente.Email = vista.txt_email.Text;
                

             


                if (operacion == "Nuevo")
                {
                    bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
                   
                    if (inserto)
                    {
                       
                        //LimpiarControles();
                        MessageBox.Show("Cliente creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ListarClientes();
                    }
                   
                    else
                    {
                        MessageBox.Show("Cliente no se pudo insertar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            catch (Exception)
            {
            }

        }
    }
}

