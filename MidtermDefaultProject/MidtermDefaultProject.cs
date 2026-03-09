namespace MidtermDefaultProject
{
    public class Midterm
    {
        public static void Main()
        {
            Book[] books = SplitBookData("Library.csv");
bool running = true;

while (running)
{
    Console.WriteLine("--- Library Menu ---");
    Console.WriteLine("1. [all]       Print all books");
    Console.WriteLine("2. [available] Print available books");
    Console.WriteLine("3. [author]    Search by author");
    Console.WriteLine("4. [year]      Search by Year (on/after)");
    Console.WriteLine("5. [sort]      Sort by Page Length");
    Console.WriteLine("6. [title]     Search single Book Info");
    Console.WriteLine("7. [checkout]  Check Out a book");
    Console.WriteLine("8. [return]    Return a book");
    Console.WriteLine("9. [sort2]     Sort by alphabetical title");
    Console.WriteLine("10. [quit]      Quit");
    Console.Write("\nChoose an option: ");

    string input = Console.ReadLine().ToLower();

    switch (input)
    {
        case "1":
            Library.PrintCatalogue(books);
            break;

        case "2":
            Library.PrintAvaliableCatalogue(books);
            break;

        case "3":
            Console.WriteLine("Enter author name to search: ");
            string author = Console.ReadLine();
            Library.PrintAuthor(books, author);
            break;

        case "4":
            Console.WriteLine("Enter minimum: ");
            try
            {
                string yearInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(yearInput))
                {
                    Console.WriteLine("Year cannot be empty.");
                    break;
                }

                int year = int.Parse(yearInput);

                if (year < 1400 || year > 2026)
                {
                    Console.WriteLine("Year must be between 1400 and 2026.");
                    break;
                }

                Library.PrintPastYear(books, year);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Invalid year input. Please enter a valid number.");
            }
            break;

        case "5":
            Library.SortByPage(books);
            Console.WriteLine("\n--- Books sorted by page length. ---\n");
            break;

        case "6":
            Console.WriteLine("Enter book title to search: ");
            string title = Console.ReadLine();
            Library.PrintBooks(books, title);
            break;

        case "7":
            Console.WriteLine("Enter book title to check out: ");
            string checkoutTitle = Console.ReadLine();
            Library.CheckOutBook(books, checkoutTitle);
            break;

        case "8":
            Console.WriteLine("Enter book title to return: ");
            string returnTitle = Console.ReadLine();
            Library.ReturnBook(books, returnTitle);
            break;
        case "9":
            Library.AlphSort(books);
        case "10":
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

}

        }

        static bool IsBool(string yn)
        {
            if (yn == "Yes")
            {
                return true;
            }
            return false;
        }

        private static Book[] SplitBookData(string path)
        {
            using StreamReader reader = new StreamReader(path);
            reader.ReadLine();
            Book[] books = new Book[GetLineCount(path) - 1];
            for (int i = 0; i < GetLineCount(path) - 1; i++)
            {
                string line = reader.ReadLine();
                string[] bookVariables = line.Split(',');
                books[i] = new Book(bookVariables[0], bookVariables[1], int.Parse(bookVariables[2]), int.Parse(bookVariables[3]), bookVariables[4], IsBool(bookVariables[5]));

            }

            return books;
        }

        private static int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("file not found");
            }
            int count = 0;
            using StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }
            return count;
        }

    }
}
        
 
