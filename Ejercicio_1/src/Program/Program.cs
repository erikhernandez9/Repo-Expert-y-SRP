using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            /* 
            Yo falte en la clase que explicaron este ejercicio, esto explica posibles fallos de comprension.
            La solucion que realice, puede ser otra, yo lo pense como una estatneria que guardaba un solo libro.*/

            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            /*book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");*/

            Estanteria estanteriaA7 = new Estanteria("A", "7");
            Estanteria estanteriaB3 = new Estanteria("B", "3");

            estanteriaA7.ShelveBook(book1);
            estanteriaB3.ShelveBook(book2);



        }
    }
}