using Persistencia.Claves;
using Persistencia.Datos;

namespace Persistencia
{
    public static class BD
    {
        // DOCUMENTO
        private static Tabla<string, DocumentoDato> tablaDocumento;
        // EJEMPLAR
        private static Tabla<ClaveEjemplar, EjemplarDato> tablaEjemplar;
        // USUARIO
        private static Tabla<string, UsuarioDato> tablaUsuario;
        // PRESTAMO
        private static Tabla<int, PrestamoDato> tablaPrestamo;
        // PERSONAL
        private static Tabla<string, PersonalDato> tablaPersonal;
        // PERSONAL_SALA
        private static Tabla<string, PersonalSalaDato> tablaPersonalSala;
        // PERSONAL_ADQUISICIONES
        private static Tabla<string, PersonalAdquisicionesDato> tablaPersonalAdquisiciones;
        // PRESTAMO_EJEMPLAR
        private static Tabla<ClavePrestamoEjemplar, PrestamoEjemplarDato> tablaPrestamoEjemplar;
        // LIBRO
        private static Tabla<string, LibroDato> tablaLibro;
        // AUDIOLIBRO
        private static Tabla<string, AudiolibroDato> tablaAudiolibro;

        // -------------------- DOCUMENTO --------------------
        public static Tabla<string, DocumentoDato> TablaDocumento
        {
            get
            {
                if (tablaDocumento == null)
                    tablaDocumento = new Tabla<string, DocumentoDato>();
                return tablaDocumento;
            }
        }

        // -------------------- EJEMPLAR --------------------
        public static Tabla<ClaveEjemplar, EjemplarDato> TablaEjemplar
        {
            get
            {
                if (tablaEjemplar == null)
                    tablaEjemplar = new Tabla<ClaveEjemplar, EjemplarDato>();
                return tablaEjemplar;
            }
        }

        // -------------------- USUARIO --------------------
        public static Tabla<string, UsuarioDato> TablaUsuario
        {
            get
            {
                if (tablaUsuario == null)
                    tablaUsuario = new Tabla<string, UsuarioDato>();
                return tablaUsuario;
            }
        }

        // -------------------- PRESTAMO --------------------
        public static Tabla<int, PrestamoDato> TablaPrestamo
        {
            get
            {
                if (tablaPrestamo == null)
                    tablaPrestamo = new Tabla<int, PrestamoDato>();
                return tablaPrestamo;
            }
        }

        // -------------------- PERSONAL --------------------
        public static Tabla<string, PersonalDato> TablaPersonal
        {
            get
            {
                if (tablaPersonal == null)
                    tablaPersonal = new Tabla<string, PersonalDato>();
                return tablaPersonal;
            }
        }

        // -------------------- PERSONAL_SALA --------------------
        public static Tabla<string, PersonalSalaDato> TablaPersonalSala
        {
            get
            {
                if (tablaPersonalSala == null)
                    tablaPersonalSala = new Tabla<string, PersonalSalaDato>();
                return tablaPersonalSala;
            }
        }

        // -------------------- PERSONAL_ADQUISICIONES --------------------
        public static Tabla<string, PersonalAdquisicionesDato> TablaPersonalAdquisiciones
        {
            get
            {
                if (tablaPersonalAdquisiciones == null)
                    tablaPersonalAdquisiciones = new Tabla<string, PersonalAdquisicionesDato>();
                return tablaPersonalAdquisiciones;
            }
        }

        // -------------------- PRESTAMO_EJEMPLAR --------------------
        public static Tabla<ClavePrestamoEjemplar, PrestamoEjemplarDato> TablaPrestamoEjemplar
        {
            get
            {
                if (tablaPrestamoEjemplar == null)
                    tablaPrestamoEjemplar = new Tabla<ClavePrestamoEjemplar, PrestamoEjemplarDato>();
                return tablaPrestamoEjemplar;
            }
        }

        // -------------------- LIBRO --------------------
        public static Tabla<string, LibroDato> TablaLibro
        {
            get
            {
                if (tablaLibro == null)
                    tablaLibro = new Tabla<string, LibroDato>();
                return tablaLibro;
            }
        }

        // -------------------- AUDIOLIBRO --------------------
        public static Tabla<string, AudiolibroDato> TablaAudiolibro
        {
            get
            {
                if (tablaAudiolibro == null)
                    tablaAudiolibro = new Tabla<string, AudiolibroDato>();
                return tablaAudiolibro;
            }
        }


    }
}