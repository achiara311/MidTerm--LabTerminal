using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    public class BookClass
    {
        private string title;
        private string author;
        private string availability;
        private DateTime dueDate;

      

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
            
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Availability
        {
            get
            {
                return availability;
            }
            set
            {
                availability = value;
            }
        }
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public BookClass()
        {

        }
        public BookClass(string _title, string _author, string _availability, DateTime _dueDate)
        {
            Title = _title;
            Author = _author;
            Availability = _availability;
            DueDate = _dueDate;
        }

    }
}
