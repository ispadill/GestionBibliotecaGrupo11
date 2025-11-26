namespace Persistencia
{
    internal class AudiolibroDato : DocumentoDato
    {
        public string Formato { get; set; }
        public int Duracion { get; set; } 

        public AudiolibroDato(string isbn, string titulo, string autor, string editorial, int año, string nss, string formato, int duracion)
            : base(isbn, titulo, autor, editorial, año, nss)
        {
            Formato = formato;
            Duracion = duracion;
        }
    }
}