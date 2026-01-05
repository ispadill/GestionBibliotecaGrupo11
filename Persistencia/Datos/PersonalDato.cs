namespace Persistencia.Datos
{
    public class PersonalDato : Entity<string>
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        public PersonalDato(string nss, string nombre, string contrasena, string rol)
            : base(nss)
        {
            Nombre = nombre;
            Contrasena = contrasena;
            Rol = rol;
        }
    }
}