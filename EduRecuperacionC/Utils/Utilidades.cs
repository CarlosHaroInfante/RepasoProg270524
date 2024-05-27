using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Utils
{
    internal class Utilidades : UtilidadesInterfaz
    {

         static public string crearNombreLog()
        {

            DateTime fecha = DateTime.Now;

            string fechaFormateada = fecha.ToString("dd, MM, yyyy");

            string nombreLog = $"log-{fechaFormateada}.txt";

            return nombreLog;

        }
    }
}
