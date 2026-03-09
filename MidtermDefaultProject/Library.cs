
namespace MidtermDefaultProject
{
    public class Library
    {

        public static void PrintCatalogue(Book[] books)
        {
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
            Console.WriteLine();
        }

        public static void PrintAvaliableCatalogue(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (!books[i].IsCheckedOut)
                {
                    Console.WriteLine(books[i]);
                }
            }
            Console.WriteLine();
        }

        public static void PrintAuthor(Book[] books, string search)
        {
            bool authorInArray = false;
            
            for(int i = 0; i < books.Length; i++ )
            {
                if (books[i].Author == search)
                {
                    Console.WriteLine(books[i]);
                    authorInArray = true;
                }
            }

            if(!authorInArray)
            {
                Console.WriteLine($"{search} was not found in library!");
            }
        }

        public static void PrintPastYear(Book[] books, int year)
        {
            for(int i = 0; i < books.Length ; i++ )
            {
                if (books[i].YearPublished >= year)
                {
                    Console.WriteLine(books[i]);
                }
            }
        }

        public static void SortByPage(Book[] books)
        {
            
            for (int i = 0; i < books.Length -1; i++)
            {
                int max = i;
                for (int j = i + 1; j < books.Length; j++)
                {
                    if (books[j].NumPages > books[max].NumPages)
                    {
                        max = j;
                    }
                }
                
                if(max !=i)
                {
                    Book temp = books[i];
                    books[i] = books[max];
                    books[max] = temp;
                }

            }
        }

        public static void PrintBooks(Book[] books, string search)
        {
            bool found = false;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == search)
                {
                    Console.WriteLine(books[i]);
found = true;
                }
            }
            if (!found) 
            {
                Console.WriteLine($"No book with the title \"{search}\" was found");
            }
    }
        public static void CheckOutBook(Book[] books, string title)
{
    for (int i = 0; i < books.Length; i++) 
    {
        if (books[i].Title == title)
        {
            if (books[i].IsCheckedOut)
            {
                Console.WriteLine("Book is already checked out.");
            }

            books[i].IsCheckedOut = true;
            Console.WriteLine("Book has been checked out!");
            return;
        }
    }
    Console.WriteLine("Book not found");
}

public static void ReturnBook(Book[] books, string title)
{
    for (int i = 0; i < books.Length;i++)
    {
        if (books[i].Title == title)
        {
            if (!books[i].IsCheckedOut)
            {
                Console.WriteLine("Book is not currently checked out.");
            }

            books[i].IsCheckedOut = false;
            Console.WriteLine("Book has been returned!");
            return;
        }
    }
    Console.WriteLine("Book not found");
}
}
}
