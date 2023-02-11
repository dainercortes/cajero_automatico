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
    public partial class Cargador : Form
    {
        public Cargador()
        {
            InitializeComponent();
        }

        private void Cargador_Load(object sender, EventArgs e)
        {
            try
            {
                this.timer1.Start();
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.timer1.Interval == 2500)
                {
                    Login log = new Login();
                    log.Show();

                    this.Hide();
                    this.timer1.Stop();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
