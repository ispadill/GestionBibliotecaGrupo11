using Persistencia.Claves;

namespace Persistencia.Datos
{
    public class EjemplarDato : Entity<ClaveEjemplar>
    {
        public bool Estado { get; set; }
        public string NSS { get; set; } // CE:Personal

        public EjemplarDato(ClaveEjemplar clave, bool estado, string nss)
            : base(clave)
        {
            Estado = estado;
            NSS = nss;
        }
    }
}