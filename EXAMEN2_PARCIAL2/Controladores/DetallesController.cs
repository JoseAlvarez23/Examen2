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
    public class DetallesController
    {
        DetallesTicketsView vista;
        DetallesDAO detallesDAO = new DetallesDAO();
        Detalles detalles = new Detalles();
        string operacion = string.Empty;
        public DetallesController(DetallesTicketsView view)
        {
            vista = view;
            vista.btn_nuevodetalle.Click += new EventHandler(Nuevo);
            vista.btn_guardardetalle.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_modificardetalle.Click += new EventHandler(Modificar);
            vista.btn_eliminardetalle.Click += new EventHandler(Eliminar);
            vista.btn_cancelardetalle.Click += new EventHandler(Cancelar);
        }
        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            detalles = null;
        }
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.DetalledataGridView.SelectedRows.Count > 0)
            {
                bool elimino = detallesDAO.EliminarDetalle(Convert.ToInt32(vista.DetalledataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Usuario Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarDetalle();
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
            if (vista.DetalledataGridView.SelectedRows.Count > 0)
            {
                vista.txt_iddetalle.Text = vista.DetalledataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_nombredetalle.Text = vista.DetalledataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txt_numerodetalle.Text = vista.DetalledataGridView.CurrentRow.Cells["NUMERO"].Value.ToString();
                vista.txt_asuntodetalle.Text = vista.DetalledataGridView.CurrentRow.Cells["ASUNTO"].Value.ToString();
                vista.cb_estadodetalle.Text = vista.DetalledataGridView.CurrentRow.Cells["ESTADOS"].Value.ToString();
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarDetalle();
        }

        private void ListarDetalle()
        {
            vista.DetalledataGridView.DataSource = detallesDAO.GetDetalle();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_nombredetalle.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombredetalle, "Por favor ingrese un Nombre");
                vista.txt_nombredetalle.Focus();
                return;
            }

            if (vista.txt_numerodetalle.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_numerodetalle, "Por favor ingrese el numero de su ticket");
                vista.txt_numerodetalle.Focus();
                return;
            }

            if (vista.txt_asuntodetalle.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_asuntodetalle, "Por favor ingrese el asunto de su ticket");
                vista.txt_asuntodetalle.Focus();
                return;
            }

            if (vista.cb_estadodetalle.Text == "")
            {
                vista.errorProvider1.SetError(vista.cb_estadodetalle, "Por favor ingrese el estado de su ticket");
                vista.cb_estadodetalle.Focus();
                return;
            }

            try
            {
                detalles.Nombre = vista.txt_nombredetalle.Text;
                detalles.Numero = vista.txt_numerodetalle.Text;
                detalles.Asunto = vista.txt_asuntodetalle.Text;
                detalles.Estados = vista.cb_estadodetalle.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = detallesDAO.InsertarNuevaDetalle(detalles);
                    if (inserto)
                    {
                        MessageBox.Show("Ticket generado fue almacenado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo almacenar generardo el ticket, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    detalles.Id = Convert.ToInt32(vista.txt_iddetalle.Text);
                    bool modifico = detallesDAO.ActualizarDetalle(detalles);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Usuario Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarDetalle();
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
            vista.txt_nombredetalle.Enabled = true;
            vista.txt_numerodetalle.Enabled = true;
            vista.txt_asuntodetalle.Enabled = true;
            vista.cb_estadodetalle.Enabled = true;

            //Habilitar Botones
            vista.btn_guardardetalle.Enabled = true;
            vista.btn_cancelardetalle.Enabled = true;
            vista.btn_eliminardetalle.Enabled = true;
            vista.btn_modificardetalle.Enabled = false;
            vista.btn_nuevodetalle.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_iddetalle.Enabled = false;
            vista.txt_nombredetalle.Enabled = false;
            vista.txt_numerodetalle.Enabled = false;
            vista.txt_asuntodetalle.Enabled = false;
            vista.cb_estadodetalle.Enabled = false;

            //Habilitar y desahiblitar Botones
            vista.btn_guardardetalle.Enabled = false;
            vista.btn_cancelardetalle.Enabled = false;
            vista.btn_modificardetalle.Enabled = true;
            vista.btn_nuevodetalle.Enabled = true;
        }
        private void LimpiarControles()
        {
            vista.txt_iddetalle.Clear();
            vista.txt_nombredetalle.Clear();
            vista.txt_numerodetalle.Clear();
            vista.txt_asuntodetalle.Clear();
            vista.cb_estadodetalle.Items.Clear();
        }

    }
}
