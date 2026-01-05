namespace Persistencia.Datos
{
    public class UsuarioDato : Entity<string>
    {
        public string Nombre { get; set; }

        public UsuarioDato(string dni, string nombre)
            : base(dni)
        {
            Nombre = nombre;
        }
    }
}