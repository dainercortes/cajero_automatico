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
    public partial class Canjear : Form
    {
        Clases.Cuenta cn = new Clases.Cuenta();
        ErrorProvider error;
        public Canjear()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        //Realiza la veriifcacion y lego canjea los puntos
        private void btn_Canjear_Click(object sender, EventArgs e)
        {
            try
            {
                bool continuar = true;

                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (cn.Id[i] == Clases.Clientes.IdActual)
                    {
                        if (Convert.ToInt32(txt_Cantidad.Text) > Clases.Cuenta.Puntos[i])
                        {
                            error.SetError(txt_Cantidad, "Puntos insuficientes");
                            continuar = false;
                        }
                        if (Convert.ToInt32(txt_Contraseña.Text) != cn.Contraseña[i])
                        {
                            error.SetError(txt_Contraseña, "Contraseña incorrecta");
                            continuar = false;
                        }
                        if (Convert.ToInt32(txt_Cantidad.Text) > Clases.Cuenta.Puntos[i])
                        {
                            error.SetError(lbl_Puntos, "No puede retirar puntos mayores a los que posee");
                            continuar = false;
                        }
                        if (Clases.Cuenta.Puntos[i] <= 0)
                        {
                            error.SetError(lbl_Puntos, "Puntos insuficientes");
                            continuar = false;
                        }
                    }
                }

                if (continuar == true)
                {
                    this.CanjearPuntos();
                    this.ActualizarVista();
                    error.Clear();
                    txt_Cantidad.Text = "";
                    txt_Contraseña.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }

        private void Canjear_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            try
            {
                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (cn.Id[i] == Clases.Cuenta.IdActual)
                    {
                        this.lbl_Saldo.Text = "Su saldo es: " + Clases.Cuenta.Saldo[i];
                        this.lbl_Puntos.Text = "Sus puntos son: " + Clases.Cuenta.Puntos[i];
                    }
                }
       
            }
            catch (Exception)
            {
            }
        }

        private void CanjearPuntos()
        {
            cn.CanjearPuntos(Convert.ToInt32(txt_Cantidad.Text));
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
