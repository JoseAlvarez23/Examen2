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
    public class EstadoController
    {

        EstadoTicketsViewcs vista;
        EstadoDAO estadoDAO = new EstadoDAO();
        Estado estado = new Estado();
        string operacion = string.Empty;

        public EstadoController(EstadoTicketsViewcs view)
        {
            vista = view;
            vista.btn_nuevoestado.Click += new EventHandler(Nuevo);
            vista.btn_guardarestado.Click += new EventHandler(Guardar);         
            vista.btn_modificarestado.Click += new EventHandler(Modificar);
            vista.btn_eliminarestado.Click += new EventHandler(Eliminar);
            vista.btn_cancelarestado.Click += new EventHandler(Cancelar);
        }
        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            estado = null;
        }
        private void Eliminar(object sender, EventArgs e)
        {
            LimpiarControles();
       

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

          
            if (vista.cb_estado.Text == "")
            {
                vista.errorProvider1.SetError(vista.cb_estado, "Por favor seleccione el estado de su ticket");
                vista.cb_estado.Focus();
                return;
            }


            try
            {
                
                estado.Estadoticket = vista.cb_estado.Text;



                if (operacion == "Nuevo")
                {
                    bool inserto = estadoDAO.InsertarNuevoEstado(estado);
                    if (inserto)
                    {
                        MessageBox.Show("El estodo de su ticket fue puesto en el sistema exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo poner el estodo de su ticket , intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    estado.Id = Convert.ToInt32(vista.txt_idestado.Text);
                    bool modifico = estadoDAO.ActualizarEstado(estado);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Estado Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Modificar el estado. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            vista.cb_estado.Enabled = true;



            //Habilitar Botones
            vista.btn_guardarestado.Enabled = true;
            vista.btn_cancelarestado.Enabled = true;
            vista.btn_eliminarestado.Enabled = true;
            vista.btn_modificarestado.Enabled = false;
            vista.btn_nuevoestado.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_idestado.Enabled = false;
            vista.cb_estado.Enabled = false;



            //Habilitar y desahiblitar Botones
            vista.btn_guardarestado.Enabled = false;
            vista.btn_cancelarestado.Enabled = false;
            vista.btn_modificarestado.Enabled = true;
            vista.btn_nuevoestado.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_idestado.Clear();
            vista.cb_estado.Items.Clear();


        }
    }
}
