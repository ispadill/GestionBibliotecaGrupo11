using System;

namespace Persistencia.Datos
{
    public class PrestamoDato : Entity<int>
    {
        public DateTime FInicio { get; set; }
        public DateTime FFin { get; set; }
        public bool Estado { get; set; }
        public string DNI { get; set; } // CE:Usuario
        public string NSS { get; set; } // CE:Personal

        public PrestamoDato(int idPrestamo, DateTime fInicio, DateTime fFin, bool estado, string dni, string nss)
            : base(idPrestamo)
        {
            FInicio = fInicio;
            FFin = fFin;
            Estado = estado;
            DNI = dni;
            NSS = nss;
        }
    }
}