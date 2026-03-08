namespace MidtermDefaultProject
{
    public class Book
    {
       
        
        private string title;
        private string author;
        private int numPages;
        private int yearPublished;
        private string genre;
        private bool isCheckedOut;

        public Book(string title, string author, int numPages, int yearPublished, string genre, bool isCheckedOut)
        {
            Title = title;
            Author = author;
            NumPages = numPages;
            YearPublished = yearPublished;
            Genre = genre; 
            IsCheckedOut = isCheckedOut;
        }

        public override string ToString()
        {
            return $"{title}: by {author} (Genre:{genre}|Published in {yearPublished}|{numPages} Pages long|Checked out:{isCheckedOut})";
        }
        
        public string Title
        {
            get => title;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Title cannot be blank or null");
                }

                title = value;
            }
        }
        
        public string Author
        {
            get => author;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Author cannot be null or blank");
                }
                author = value;
            }
        }

        public int NumPages
        {
            get => numPages;
            set
            {
                if(value < 0  || value > 2000)
                {
                    throw new Exception("number of pages cannot be negative or greater than 2000");
                }
                numPages = value;
            }
        }

        public int YearPublished
        {
            get => yearPublished;
            set
            {
                if(value < 1400 || value >  2026)
                {
                    throw new Exception("Year published cannot be greater than 2026 or less than 1400");
                }

                yearPublished = value;
            }
        }

        public string Genre
        {
            get => genre;

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Genre cannot be null or blank");
                }

                genre = value;
            }
        }

        public bool IsCheckedOut
        {
            get => isCheckedOut;
            set => isCheckedOut = value;
        }

    }
}
