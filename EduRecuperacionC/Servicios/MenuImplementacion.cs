using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu() {

            Console.WriteLine("Menu de la aplicación");
            Console.WriteLine("---------------------");
            Console.WriteLine("[0] - Cerrar menú");
            Console.WriteLine("[1] - Alta de objetos");
            Console.WriteLine("---------------------");

            int op = Convert.ToInt32(Console.ReadLine());   

            return op;


        }
    }
}
