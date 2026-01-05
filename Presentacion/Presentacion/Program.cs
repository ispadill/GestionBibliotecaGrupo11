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

            /// --- DATOS DE PRUEBA  ---
            var pepe = new PersonalSalaDato("123", "Pepe Sala", "1234", "SALA");
            BD.TablaPersonal.Add(pepe); 
            BD.TablaPersonalSala.Add(pepe); 


            var ana = new PersonalAdquisicionesDato("456", "Ana Adq", "4567", "ADQUISICIONES");
            BD.TablaPersonal.Add(ana);
            BD.TablaPersonalAdquisiciones.Add(ana);

            //Para FAltaPrestamo
            BD.TablaUsuario.Add(new UsuarioDato("111", "Juan Lector"));
            var libro = new LibroDato("555", "El Quijote", "Cervantes", "Planeta", 1605, "789");
            BD.TablaDocumento.Add(libro);
            BD.TablaEjemplar.Add(new EjemplarDato(new Persistencia.Claves.ClaveEjemplar("555", "C1"), true, "789"));

            Application.Run(new FLogin());
        }
    }
}
