using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Programador: Dainer Camilo Cortés Ramírez 
 * Grupo: 126
 */

namespace CajeroAutomatico
{
    public partial class Login : Form
    {
        Clases.Clientes cli = new Clases.Clientes();
        ErrorProvider error;

        public Login()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        //Realiza la verificacion y luego inicia sesion
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                bool continuar = false;
                bool usuarioEncontrado = false;

                for (int i = 0; i < cli.Id.Length; i++)
                {
                    if (cli.Id[i] == Convert.ToInt32(this.txt_Usuario.Text))
                    {
                        usuarioEncontrado = true;

                        if (Convert.ToInt32(txt_Contraseña.Text) == cli.Contraseña[i])
                        {        
                            continuar = true;
                        }
                        else
                        {
                            error.SetError(txt_Contraseña, "Contraseña incorrecta");
                        }
                    }
                }

                if (usuarioEncontrado == false)
                {
                    error.SetError(txt_Usuario, "Usuario no encontado");
                }

                if (continuar == true)
                {
                    this.IniciarSesion();
                    error.Clear();
                    Opciones op = new Opciones();
                    op.Show();
                    this.Hide();
                }     
            }
            catch (Exception)
            {
            }         
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void IniciarSesion()
        {
            cli.IniciarSesion(Convert.ToInt32(txt_Usuario.Text));
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    error.Clear();
                    e.Handled = false;
                }
                else
                {
                    error.SetError(txt_Usuario, "Por favor solo ingrese números");
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    error.Clear();
                    e.Handled = false;
                }
                else
                {
                    error.SetError(txt_Contraseña, "Por favor solo ingrese números");
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
