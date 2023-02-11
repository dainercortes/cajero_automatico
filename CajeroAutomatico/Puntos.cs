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
    public partial class Puntos : Form
    {
        Clases.Cuenta cn = new Clases.Cuenta();
        public Puntos()
        {
            InitializeComponent();
        }

        private void Puntos_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cn.Id.Length; i++)
                {
                    if (cn.Id[i] == Clases.Cuenta.IdActual)
                    {
                        this.lbl_Nombre.Text = "Sr " + cn.Nombre[i];
                        this.lbl_Puntos.Text = "Usted cuenta con un total de " + Clases.Cuenta.Puntos[i] + " puntos";
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
