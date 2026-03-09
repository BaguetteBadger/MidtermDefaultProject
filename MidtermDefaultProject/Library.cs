
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
            
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == search)
                {

                }
            }

    }
}
}
