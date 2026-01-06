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

            // --- DATOS DE PRUEBA AMPLIADOS ---

            // 1. PERSONAL DE BIBLIOTECA (Actores del sistema)
            var pSala1 = new PersonalSalaDato("123", "Pepe Sala", "1234", "SALA");
            var pSala2 = new PersonalSalaDato("789", "PersSala", "sala123", "SALA");
            var pAdq1 = new PersonalAdquisicionesDato("456", "Ana Adq", "4567", "ADQUISICIONES");
            var pAdq2 = new PersonalAdquisicionesDato("012", "PersAdqui", "adq123", "ADQUISICIONES");


            BD.TablaPersonal.Add(pSala1); BD.TablaPersonalSala.Add(pSala1);
            BD.TablaPersonal.Add(pSala2); BD.TablaPersonalSala.Add(pSala2);
            BD.TablaPersonal.Add(pAdq1); BD.TablaPersonalAdquisiciones.Add(pAdq1);
            BD.TablaPersonal.Add(pAdq2); BD.TablaPersonalAdquisiciones.Add(pAdq2);

            // 2. USUARIOS (Lectores)
            BD.TablaUsuario.Add(new UsuarioDato("111", "Juan Lector"));
            BD.TablaUsuario.Add(new UsuarioDato("000", "Ismael"));
            BD.TablaUsuario.Add(new UsuarioDato("678", "Hugo"));
            BD.TablaUsuario.Add(new UsuarioDato("400", "Francisco"));
            BD.TablaUsuario.Add(new UsuarioDato("222", "Maria Curiosa"));

            // 3. DOCUMENTOS: LIBROS (15 días de préstamo)
            var quijote = new LibroDato("555", "El Quijote", "Cervantes", "Planeta", 1605, "456");
            var csharp = new LibroDato("777", "C# Avanzado", "M. Smith", "Tecnos", 2023, "456");
            BD.TablaDocumento.Add(quijote);
            BD.TablaDocumento.Add(csharp);

            // 4. DOCUMENTOS: AUDIOLIBROS (10 días de préstamo) [cite: 146, 158]
            var audio1 = new AudiolibroDato("999", "Harry Potter Audio", "JK Rowling", "Salamandra", 2001, "456", "MP3", 36000);
            BD.TablaDocumento.Add(audio1);

            // 5. EJEMPLARES Copias físicas/digitales
                        // El Quijote tiene 2 copias
            BD.TablaEjemplar.Add(new EjemplarDato(new Persistencia.Claves.ClaveEjemplar("555", "C1"), true, "456"));
            BD.TablaEjemplar.Add(new EjemplarDato(new Persistencia.Claves.ClaveEjemplar("555", "C2"), true, "456"));
            
            BD.TablaEjemplar.Add(new EjemplarDato(new Persistencia.Claves.ClaveEjemplar("777", "C1"), true, "456"));
            
            BD.TablaEjemplar.Add(new EjemplarDato(new Persistencia.Claves.ClaveEjemplar("999", "D1"), true, "456"));

            // ---------------------------------
            Application.Run(new FLogin());
        }
    }
}
