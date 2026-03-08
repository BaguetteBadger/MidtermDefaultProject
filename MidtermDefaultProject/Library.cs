
namespace MidtermDefaultProject
{
    public class Library
    {

        public static void PrintCatalogue(Book[] library)
        {
            for(int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i]);
            }
        }

        public static void PrintAvaliableCatalogue(Book[] library)
        {
            for (int i = 0; i < library.Length; i++)
            {
                if (!library[i].IsCheckedOut)
                {
                    Console.WriteLine(library[i]);
                }
            }
        }

    }
}
