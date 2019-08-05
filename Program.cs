using System;
using System.Collections.Generic;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {

            bool again = true;
            while (again)
            {
                Display();
                Console.WriteLine("\nPlease make your selection.\n");
                string input = Console.ReadLine();
                bool isValid = Validator.IsValidInt(input);
                /* while (!isValid == Validator.IsValidInt(Con);
                 if(isValid == true)
                 {
                     Console.WriteLine("You messed up.");
                 }
                 */

                int selection = int.Parse(input);
                if (selection == 1)
                {
                    //List Library

                    DisplayBooks();
                }
                else if (selection == 2)
                {
                    //search by author
                    Console.WriteLine("Type in a author.");
                    string author = Console.ReadLine();
                    List<BookClass> yes = SearchAuthor(author);
                    DisplayBooks(yes);

                }
                else if (selection == 3)
                { //search by title
                    Console.WriteLine("Type by book title.");
                    string title = Console.ReadLine();
                    List<BookClass> hey = SearchTitle(title);
                    DisplayBooks(hey);
                    
                }
                else if (selection == 4)
                {
                    SearchAvailability();
                   
                }
                else if (selection == 5)
                {
                    //return book
                    Console.WriteLine("\nType 'in' or 'out' if the book is in.");
                    string inThere = Console.ReadLine().ToLower();
                    
                    List<BookClass> OhItMightBeThere = InThere(inThere);
                    DisplayBooks(OhItMightBeThere);
                    if(inThere == "out")
                    {
                        List<BookClass> OhItsNot = InThere(inThere);
                        DisplayBooks(OhItsNot);
                        Console.WriteLine("Would you like to return book? y/n");
                        string accept = Console.ReadLine().ToLower();
                        if(accept == "yes" || accept == "y")
                        {
                            Console.WriteLine("Type in a title.");
                            string title = Console.ReadLine().ToLower();

                            for (int i = 0; i < ListOfLists.books.Count; i++)
                            {
                                if (title == ListOfLists.books[i].Title.ToLower())
                                {
                                    ListOfLists.books[i].Availability = "in";
                                    Console.WriteLine($"{ListOfLists.books[i].Title} has been return and is now {ListOfLists.books[i].Availability}.");
                                }
                            }
                            
                            DisplayBooks(ListOfLists.books);

                        }
                        else
                        {
                            Display();
                        }

                    }
                    else if(inThere == "in")
                    {
                        List<BookClass> OhItsNot = InThere(inThere);
                        DisplayBooks(OhItsNot);
                        Console.WriteLine("Would you like to check book out? y/n");
                        string submit = Console.ReadLine().ToLower();
                        //int integer = int.Parse(submit);
                        if (submit == "yes" || submit == "y")
                        {
                            Console.WriteLine("Type in a title.");
                            string title = Console.ReadLine().ToLower();

                            for (int i = 0; i < ListOfLists.books.Count; i++)
                            {
                                if (title == ListOfLists.books[i].Title.ToLower())
                                {
                                    ListOfLists.books[i].Availability = "out";
                                    ListOfLists.books[i].DueDate = (DateTime.Now.Date).AddDays(14);
                                    Console.WriteLine($"\n{ListOfLists.books[i].DueDate} is when it needs to be returned.");
                                }
                            }
                            Console.WriteLine();
                            DisplayBooks(ListOfLists.books);
                        }
                    }
                    
                }
                else if (selection == 6)
                {

                    Quit();
                    Console.WriteLine("\nSee you soon nerd!");
                    again = false;
                }
                else
                {
                    Console.WriteLine("Try again.");
                    again = false;
                }
            }
        }

        public static bool Quit()
        {
            return false;
        }
        public static void Display()
        {
            Console.WriteLine("HI THERE! WELCOME TO THE LIBRARY.\n");

            Console.WriteLine("\t1. List Library");

            Console.WriteLine("\t2. Search By Author");
            Console.WriteLine("\t3. Search By Title");
            Console.WriteLine("\t4. Check Availability ");
            Console.WriteLine("\t5. Check Out/Return Book");
            Console.WriteLine("\t6. Leave");

        }
        public static int ParseMethod()
        {

            try
            {
                int input = int.Parse(Console.ReadLine());
                return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a number.");
                return ParseMethod();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large a number");
                return ParseMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}.");
                return ParseMethod();
            }

        }
      
        public static void DisplayBooks(List<BookClass> classics)
        {
            foreach (BookClass pages in classics)
            {
                Console.WriteLine(pages.Title);
                Console.WriteLine(pages.Author);
                Console.WriteLine(pages.Availability);
                Console.WriteLine(pages.DueDate.ToString("MM/dd/yyyy"));
                Console.WriteLine();

            }
        }
        public static void DisplayBooks()
        {
            foreach (BookClass pages in ListOfLists.books)
            {
                Console.WriteLine(pages.Title);
                Console.WriteLine(pages.Author);
               // Console.WriteLine(pages.Availability);
               // Console.WriteLine(pages.DueDate.ToString("MM/dd/yyyy"));
                Console.WriteLine();
            }
        }

        public static List<BookClass> SearchAuthor(string author)
        {
            List<BookClass> classics = new List<BookClass>();
            foreach (BookClass reads in ListOfLists.books)
            {
                if (reads.Author.ToLower() == author.ToLower())
                {
                    classics.Add(reads);
                }
            }

            return classics;
        }

        public static List<BookClass> SearchTitle(string title)
        {
            List<BookClass> titleNew = new List<BookClass>();
            foreach (BookClass meh in ListOfLists.books)
            {
                if (meh.Title.ToLower() == title.ToLower())
                {
                    titleNew.Add(meh);
                }
            }

            return titleNew;
        }

        public static List<BookClass> InThere(string available)
        {
            List<BookClass> canYouCheck = new List<BookClass>();
            foreach (BookClass isItIn in ListOfLists.books)
            {
                if (isItIn.Availability.ToLower() == available.ToLower())
                {
                    canYouCheck.Add(isItIn);
                }

            }
            return canYouCheck;
        }
        public static void SearchAvailability()
        {
            foreach (BookClass pages in ListOfLists.books)
            {
                Console.WriteLine(pages.Title);
                Console.WriteLine(pages.Author);
                Console.WriteLine(pages.Availability);
                Console.WriteLine(pages.DueDate.ToString("MM/dd/yyyy"));
                Console.WriteLine();
            }
        }
    }
}
