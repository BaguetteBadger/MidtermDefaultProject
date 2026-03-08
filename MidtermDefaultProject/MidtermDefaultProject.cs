namespace MidtermDefaultProject
{
    public class Midterm
    {
        public static void Main()
        {
            Book[] books = SplitBookData("Library.csv");

            Library.PrintCatalogue(books);
            Library.SortByPage(books);
            Library.PrintCatalogue(books);

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
        
 
