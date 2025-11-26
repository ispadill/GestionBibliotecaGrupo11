namespace Persistencia
{
    internal class LibroDato : DocumentoDato
    {
        public LibroDato(string isbn, string titulo, string autor, string editorial, int año, string nss)
            : base(isbn, titulo, autor, editorial, año, nss)
        {
        }
    }
}