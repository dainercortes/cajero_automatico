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
    public partial class Opciones : Form
    {
        private DateTime Fecha = new DateTime();
        private bool mostrar = true;
       
        public Opciones()
        {
            InitializeComponent();
        }

        //Metodo para abrir formulario dentro de otro formulario
        private void abrirFormHijo(object formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
            {
                this.panel_Contenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_ConsultarS_Click(object sender, EventArgs e)
        {      
            abrirFormHijo(new Saldo());
        }

        private void btn_ConsultarP_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Puntos());
        }

        private void btn_RetirarS_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Retirar());
        }

        private void btn_Transferir_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Transferencias());
        }
        
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            abrirFormHijo(new FechayHora());
        }

        private void lbl_Inicio_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new FechayHora());
        }

        private void btn_CanjearP_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Canjear());
        }
    }
}
