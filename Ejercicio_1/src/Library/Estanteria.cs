using System;

namespace SRP
{
    public class Estanteria
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public Book LibrosArchivado;

        public Estanteria(string librarysector, string libraryshelve)
        {
            this.LibrarySector = librarysector;
            this.LibraryShelve = libraryshelve;
        }

        public void ShelveBook(Book book) // Podria usar el set pero hago el metodo para cumplir con la utilizacion de este
        {
            LibrosArchivado = book;
        }
    }
}