using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Programador: Dainer Camilo Cortés Ramírez 
 * Grupo: 126
 */

namespace CajeroAutomatico.Clases
{
    class Clientes
    {
        //Atributos de la clase
        public string[] Nombre = new string[] { "Dainer Cortes", "Jose Caceres", "Manuel Ramirez" };
        public int[] Id = new int[] { 20134, 30532, 10567 };
        public int[] Contraseña = new int[] {1234, 4432, 5678};      
        public static int IdActual;

        public Clientes() 
        {

        }
 
        public void IniciarSesion(int nombre)
        {
            try
            {
                IdActual = nombre;          
            }
            catch (Exception)
            { 
            }
        }
    }
}
