using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  } // Supongo que esto seria el codigo identificador del libro
        /*
        Las siguientes variables tendrian que ir en otra clase, 
        debido a que el objetivo de esta clase es guardar informacion del libro
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        */
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    
        /* 
        La siguiente funcion tendria que ir en otra clase, 
        debido a que esta clase deberia guardar informacion del libro 
        y este metodo estaria haciendo otras cosas
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */
    }
}