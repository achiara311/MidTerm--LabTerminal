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
                {
                    Console.WriteLine("Type by book title.");
                    string title = Console.ReadLine();
                    List<BookClass> hey = SearchTitle(title);
                    DisplayBooks(hey);
                    //search by title
                }
                else if (selection == 4)
                {

                    //return book
                    Console.WriteLine("\nType 'in' or 'out' if the book is in.");
                    string inThere = Console.ReadLine();
                    List<BookClass> OhItMightBeThere = InThere(inThere);
                    DisplayBooks(OhItMightBeThere);
                    again = true;
                }
                else if (selection == 5)
                {
                    //return book
                    Console.WriteLine("\nType in or out if the book is in.");
                    string inThere = Console.ReadLine();
                    List<BookClass> OhItMightBeThere = InThere(inThere);
                    DisplayBooks(OhItMightBeThere);
                    Console.WriteLine("Would you like to check book out? 1.y 2.n");
                    int count = 0;
                    string submit = Console.ReadLine();
                    //int integer = int.Parse(submit);
                    if (submit == "yes" || submit == "y")
                    {
                        count++;
                        Console.WriteLine("Type in a author.");
                        string author = Console.ReadLine();
                        //int submission = int.Parse(author);
                        ListOfLists.books[count].Author = "out";
                        Console.WriteLine(author[count]);
                        //wtf??????????!?!?!?!?!?!?
                        

                    }
                    //count++;
                }
                else if (selection == 6)
                {

                    Quit();
                    Console.WriteLine("See you soon! Return your books!");
                    again = false;
                }
                else
                {
                    //try again 
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
            Console.WriteLine("\t5. Return Book");
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
        /*public static int Parse()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }*/
        public static void DisplayBooks(List<BookClass> classics)
        {
            foreach (BookClass pages in classics)
            {
                Console.WriteLine(pages.Title);
                Console.WriteLine(pages.Author);
                Console.WriteLine(pages.Availability);
                // Console.WriteLine(pages.DueDate.ToString("MM/dd/yyyy"));
                Console.WriteLine();

            }
        }
        public static void DisplayBooks()
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
            int count = 0;
            List<BookClass> canYouCheck = new List<BookClass>();
            foreach (BookClass x in ListOfLists.books)
            {
                count++;
                if (x.Availability.ToLower() == available.ToLower())
                {
                    canYouCheck.Add(x);
                }

            }
            return canYouCheck;
        }
        public static void SearchAvailability()
        {
            int counter = 0;
            foreach (BookClass available in ListOfLists.books)
            {
                counter++;
                Console.WriteLine(available.Title);
                Console.WriteLine(available.Author);
                Console.WriteLine($"{counter}. available.Availability");
                Console.WriteLine(available.DueDate.ToString("MM/dd/yyyy"));
                Console.WriteLine();

            }
        }

    }
}
