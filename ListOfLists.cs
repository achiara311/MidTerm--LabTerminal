using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    public class ListOfLists
    {




        public static List<BookClass> books = new List<BookClass>()
        {
             new BookClass("Harry Potter", "Jk Rowling", "In", DateTime.Now.Date),
             new BookClass("The Martian Chronicles", "Ray Bradbury", "In", DateTime.Now.Date),
             new BookClass("Two Towers", "JRR Tolkien", "In", DateTime.Now.Date),
             new BookClass("GodFather", "Mario Puzo", "In", DateTime.Now.Date),
             new BookClass("Dragons Love Tacos", "Adam Rubin", "In", DateTime.Now.Date),
             new BookClass("Becoming", "Michelle Obama", "Out", DateTime.Now.Date),
             new BookClass("Advanced Potions", "Half-Blood Prince", "In", DateTime.Now.Date),
             new BookClass("Mary Poppins", "P.L. Travers", "In", DateTime.Now.Date),
             new BookClass("A Clash Of Kings", "George R.R. Martin", "Out", DateTime.Now.Date),
             new BookClass("Marley & Me", "John Grogan", "Out", DateTime.Now.Date),
             new BookClass("Treasure Island", "Robert L Stevenson", "In", DateTime.Now.Date)
        };








    }
}


