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
    public partial class FechayHora : Form
    {
        public FechayHora()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
            lbl_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void FechayHora_Load(object sender, EventArgs e)
        {

        }
    }
}
