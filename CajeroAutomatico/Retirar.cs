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
    public partial class Retirar : Form
    {
        Clases.Cuenta cn = new Clases.Cuenta();
        ErrorProvider error;
        public Retirar()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        //Realiza la verificacion y luego retira el dinero
        private void btn_Retirar_Click(object sender, EventArgs e)
        {
            try
            {
                bool continuar = true;

                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (cn.Id[i] == Clases.Clientes.IdActual)
                    {
                        if (Convert.ToDecimal(txt_Cantidad.Text) > Clases.Cuenta.Saldo[i])
                        {
                            error.SetError(txt_Cantidad, "Dinero insuficiente");
                            continuar = false;
                        }
                        if (Convert.ToInt32(txt_Contraseña.Text) != cn.Contraseña[i])
                        {
                            error.SetError(txt_Contraseña, "Contraseña incorrecta");
                            continuar = false;
                        }
                        if (Convert.ToDecimal(txt_Cantidad.Text) > Clases.Cuenta.TopeDiario)
                        {
                            error.SetError(lbl_TopeDiario, "Solo puede retirar una cantidad menor o igual a esta");
                            continuar = false;
                        }
                        if (Clases.Cuenta.TopeDiario <= 0)
                        {
                            error.SetError(lbl_TopeDiario, "Tope diario de retiros alcanzado");
                            continuar = false;
                        }
                    }
                }

                if (continuar == true)
                {
                    this.RetirarSaldo();
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

        private void Retirar_Load(object sender, EventArgs e)
        {
            this.ActualizarVista();
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
                    }
                }
                this.lbl_TopeDiario.Text = "Tope diario de retiro: " + Clases.Cuenta.TopeDiario;
            }
            catch (Exception)
            {
            }
        }

        private void RetirarSaldo()
        {
            cn.RetirarSaldo(Convert.ToDecimal(this.txt_Cantidad.Text));
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
