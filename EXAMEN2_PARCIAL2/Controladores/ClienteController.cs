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
            vista.btn_modificar.Click += new EventHandler(Modificar);
            vista.btn_eliminar.Click += new EventHandler(Eliminar);
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.ClientesDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = clienteDAO.EliminarCliente(Convert.ToInt32(vista.ClientesDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Usuario Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se puedo Eliminar el usuario. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.ClientesDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_id.Text = vista.ClientesDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_identidad.Text = vista.ClientesDataGridView.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                vista.txt_nombre.Text = vista.ClientesDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txt_email.Text = vista.ClientesDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();               
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.ClientesDataGridView.DataSource = clienteDAO.GetCliente();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_identidad.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_identidad, "Por favor ingrese una Identidad");
                vista.txt_identidad.Focus();
                return;
            }
            if (vista.txt_nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "Por favor ingrese un Nombre");
                vista.txt_nombre.Focus();
                return;
            }
            if (vista.txt_email.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Por favor ingrese un Email");
                vista.txt_email.Focus();
                return;
            }
           

            try
            {
                cliente.Identidad = vista.txt_identidad.Text;
                cliente.Nombre = vista.txt_nombre.Text.ToUpper();
                cliente.Email = vista.txt_email.Text;


                if (operacion == "Nuevo")
                {
                    bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
                    if (inserto)
                    {
                        MessageBox.Show("Cliente creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el Cliente, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    cliente.Id = Convert.ToInt32(vista.txt_id.Text);
                    bool modifico = clienteDAO.ActualizarCliente(cliente);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Usuario Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
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
            vista.txt_identidad.Enabled = true;
            vista.txt_nombre.Enabled = true;
            vista.txt_email.Enabled = true;
            

            //Habilitar Botones
            vista.btn_guardar.Enabled = true;
            vista.btn_cancelar.Enabled = true;
            vista.btn_eliminar.Enabled = true;
            vista.btn_modificar.Enabled = false;
            vista.btn_nuevo.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_id.Enabled = false;
            vista.txt_nombre.Enabled = false;
            vista.txt_email.Enabled = false;
            vista.txt_identidad.Enabled = false;
            

            //Habilitar y desahiblitar Botones
            vista.btn_guardar.Enabled = false;
            vista.btn_cancelar.Enabled = false;
            vista.btn_modificar.Enabled = true;
            vista.btn_nuevo.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_id.Clear();
            vista.txt_nombre.Clear();
            vista.txt_email.Clear();
            vista.txt_identidad.Clear();
            
        }
    }
}

