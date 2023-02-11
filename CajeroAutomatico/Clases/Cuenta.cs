using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Programador: Dainer Camilo Cortés Ramírez 
 * Grupo: 126
 */

namespace CajeroAutomatico.Clases
{
    class Cuenta : Clientes
    {
        //Atributos de la clase
        public static decimal[] Saldo = new decimal[] { 5000000, 4800000, 2555000 };
        public static int[] Puntos = new int[] { 200, 300, 100 };
        public static decimal TopeDiario = 2000000;

        public Cuenta()
        {

        }

        public void RetirarSaldo(decimal saldo)
        {
            try
            {
                for (int i = 0; i < this.Id.Length; i++)
                {
                    if (this.Id[i] == IdActual)
                    {
                        Saldo[i] -= saldo;
                        TopeDiario -= saldo;
                        MessageBox.Show("Retiro exitoso");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void TransferirSaldo(int id, decimal saldo, int contraseña)
        {
            try
            {
                for (int i = 0; i < this.Id.Length; i++)
                {
                    if (this.Id[i] == IdActual)
                    {
                        Saldo[i] -= saldo;
                    }
                    if (this.Id[i] == id)
                    {
                        Saldo[i] += saldo;
                        MessageBox.Show("Se enviaron " + saldo + " a " + this.Nombre[i]);
                    }
                }
            }
            catch (Exception)
            {
            }         
        }
        public void CanjearPuntos(int puntos)
        {
            for (int i = 0; i < this.Id.Length; i++)
            {
                if (this.Id[i] == IdActual)
                {
                    Saldo[i] = Saldo[i] + (puntos * 100);
                    Puntos[i] -= puntos;
                    MessageBox.Show("Canjeo exitoso");
                }
            }
        }
    }
}
