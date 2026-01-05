using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using Persistencia.Datos;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // --- DATOS DE PRUEBA ---
            // Añadimos un trabajador de Sala
            BD.TablaPersonal.Add(new PersonalDato("123", "Pepe Sala", "1234", "SALA"));
            BD.TablaPersonalSala.Add(new PersonalSalaDato("123", "Pepe Sala", "1234", "SALA"));
            // Añadimos un trabajador de Adquisiciones
            BD.TablaPersonal.Add(new PersonalDato("456", "Ana Adq", "4567", "ADQUISICIONES"));
            BD.TablaPersonalAdquisiciones.Add(new PersonalAdquisicionesDato("456", "Ana Adq", "4567", "ADQUISICIONES"));

            // -----------------------


            Application.Run(new FLogin());
        }
    }
}
