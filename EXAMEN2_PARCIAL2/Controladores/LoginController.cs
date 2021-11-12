using EXAMEN2_PARCIAL2.Modelos.DAO;
using EXAMEN2_PARCIAL2.Modelos.Entidades;
using EXAMEN2_PARCIAL2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN2_PARCIAL2.Controladores
{
    public class LoginController
    {

        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;


            vista.btn_aceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;

            UsuariaoDAO userDao = new UsuariaoDAO();

            Usuario user = new Usuario();

            //De la siguiente forma podremos darle a la propiedad el valor de lo que hay en el textbox
            user.Email = vista.txt_email.Text;
            user.Clave = EncriptarClave(vista.txt_clave.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("USUARIO VALIDO");
                //MenuView menu = new MenuView();
                //vista.Hide();
                //menu.Show();

            }
            else
            {
                MessageBox.Show("USUARIO NO VALIDO");
            }

        }
        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}

