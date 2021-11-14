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
    public class SoporteController
    {
        SoporteView vista;
        SoporteDAO soporteDAO = new SoporteDAO();
        Soporte soporte = new Soporte();
        string operacion = string.Empty;

        public SoporteController(SoporteView view)
        {
            vista = view;
            vista.btn_nuevosoporte.Click += new EventHandler(Nuevo);
            vista.btn_guardarsoporte.Click += new EventHandler(Guardar);
            vista.btn_modificarsoporte.Click += new EventHandler(Modificar);
            vista.btn_eliminarsoporte.Click += new EventHandler(Eliminar);
            vista.btn_cancelarsoporte.Click += new EventHandler(Cancelar);
        }
        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            soporte = null;
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
            
            if (vista.txt_dispositivo.Text == "")
            {
                vista.errorProvider2.SetError(vista.txt_dispositivo, "Por favor ingrese un dispocitivo");
                vista.txt_dispositivo.Focus();
                return;
            }
            if (vista.cb_tiposoporte.Text == "")
            {
                vista.errorProvider2.SetError(vista.cb_tiposoporte, "Por favor seleccione un servicio");
                vista.cb_tiposoporte.Focus();
                return;
            }


            try
            {
                soporte.Dispositivo = vista.txt_dispositivo.Text;
                soporte.Tiposoporte = vista.cb_tiposoporte.Text;
               


                if (operacion == "Nuevo")
                {
                    bool inserto = soporteDAO.InsertarNuevoSoporte(soporte);
                    if (inserto)
                    {
                        MessageBox.Show("Solicitud de servicio solicitada exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo hacer la  Solicitud de servicio , intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    soporte.Id = Convert.ToInt32(vista.txt_idservicios.Text);
                    bool modifico = soporteDAO.ActualizarSoporte(soporte);
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
            vista.txt_dispositivo.Enabled = true;
            vista.cb_tiposoporte.Enabled = true;
            


            //Habilitar Botones
            vista.btn_guardarsoporte.Enabled = true;
            vista.btn_cancelarsoporte.Enabled = true;
            vista.btn_eliminarsoporte.Enabled = true;
            vista.btn_modificarsoporte.Enabled = false;
            vista.btn_nuevosoporte.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_idservicios.Enabled = false;
            vista.txt_dispositivo.Enabled = false;
            vista.cb_tiposoporte.Enabled = false;



            //Habilitar y desahiblitar Botones
            vista.btn_guardarsoporte.Enabled = false;
            vista.btn_cancelarsoporte.Enabled = false;
            vista.btn_modificarsoporte.Enabled = true;
            vista.btn_nuevosoporte.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_idservicios.Clear();
            vista.txt_dispositivo.Clear();
            vista.cb_tiposoporte.Items.Clear();
           

        }
    }
}
