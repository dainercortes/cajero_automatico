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
    public partial class Transferencias : Form
    {
        Clases.Cuenta cn = new Clases.Cuenta();
        ErrorProvider error;
        public Transferencias()
        {
            error = new ErrorProvider();
            InitializeComponent();
        }

        private void ActualizarSaldo()
        {           
          cn.TransferirSaldo(Convert.ToInt32(txt_Usuario.Text), Convert.ToDecimal(txt_Cantidad.Text), Convert.ToInt32(txt_Contraseña.Text));
        }
        private void ActualizarVista()
        {
            try
            {
                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (cn.Id[i] == Clases.Cuenta.IdActual)
                    {
                        this.lbl_Saldo.Text = "Usted cuenta con un saldo de: " + Clases.Cuenta.Saldo[i];
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void Transferencias_Load(object sender, EventArgs e)
        {
            this.ActualizarVista();
        }

        //Realiza las validaciones y luego hace la tranferencia
        private void btn_Transferir_Click(object sender, EventArgs e)
        {
            try
            {
                bool continuar = true;

                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (!cn.Id.Contains(Convert.ToInt32(txt_Usuario.Text)))
                    {
                        error.SetError(txt_Usuario, "Usuario no encontrado");
                        continuar = false;
                    }
                    if (Convert.ToInt32(txt_Usuario.Text) == Clases.Clientes.IdActual)
                    {
                        error.SetError(txt_Usuario, "No puede transferirse dinero a usted mismo");
                        continuar = false;
                    }
                    if (cn.Id[i] == Clases.Clientes.IdActual)
                    {
                        if (Convert.ToDecimal(txt_Cantidad.Text) >= Clases.Cuenta.Saldo[i])
                        {
                            error.SetError(txt_Cantidad, "Dinero insuficiente");
                            continuar = false;
                        }
                        if (Convert.ToInt32(txt_Contraseña.Text) != cn.Contraseña[i])
                        {
                            error.SetError(txt_Contraseña, "Contraseña incorrecta");
                            continuar = false;
                        }
                    }

                }
                if (continuar == true)
                {
                    this.ActualizarSaldo();
                    this.ActualizarVista();
                    error.Clear();
                    txt_Usuario.Text = "";
                    txt_Cantidad.Text = "";
                    txt_Contraseña.Text = "";
                }
            }
            catch (Exception)
            {
            }
     
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

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
                    error.SetError(txt_Cantidad, "Por favor solo ingrese números");
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
