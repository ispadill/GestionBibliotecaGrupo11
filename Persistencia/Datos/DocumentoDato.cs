namespace Persistencia.Datos
{
    public class DocumentoDato : Entity<string>
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Año { get; set; }
        public string NSS { get; set; } // CE:Personal

        public DocumentoDato(string isbn, string titulo, string autor, string editorial, int año, string nss)
            : base(isbn)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Año = año;
            NSS = nss;
        }
    }

}