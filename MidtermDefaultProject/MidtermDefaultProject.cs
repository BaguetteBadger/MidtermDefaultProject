namespace MidtermDefaultProject
{
    public class Midterm
    {
        public static void Main()
        {
            Book book1 = new Book("sad", "asd", 300, 2000, "124", true);

            Console.WriteLine(book1);
        }
        static Book[] SplitBookData(string path){
            using StreamReader reader = new StreamReader(path);
reader.ReadLine();
Book[] books = new Book[GetLineCount(path)-1];
for (int i = 0; i < GetLineCount(path)-1; i++) {
string line = reader.ReadLine();
string[] bookVariables = line.Split(',');
movies[i] = new Book(bookVariables[0], int.Parse(bookVariables[3]), bookVariables[2], bookVariables[1], double.Parse(bookVariables[4]));

    }
            static int GetLineCount(string path)
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
