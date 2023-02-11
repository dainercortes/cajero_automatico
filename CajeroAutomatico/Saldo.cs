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
    public partial class Saldo : Form
    {
        Clases.Cuenta cn = new Clases.Cuenta();
        public Saldo()
        {
            InitializeComponent();
            ActualizarSaldo();
        }

        private void Saldo_Load(object sender, EventArgs e)
        {
            ActualizarSaldo();
        }
        private void ActualizarSaldo()
        {
            try
            {
                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (cn.Id[i] == Clases.Cuenta.IdActual)
                    {
                        this.lbl_Nombre.Text = "Sr " + cn.Nombre[i];
                        this.lbl_Saldo.Text = "Usted cuenta con un saldo de: " + Clases.Cuenta.Saldo[i];
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
