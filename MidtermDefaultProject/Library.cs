
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
     Array.Sort(books, (b1, b2) => b2.NumPages.CompareTo(b1.NumPages));
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
            DateTime checkoutDate = DateTime.Now;
DateTime dueDate = DateTime.Now.AddDays(14);
Console.WriteLine("Book has been checked out!");
Console.WriteLine("Checkout Date: " + checkoutDate.ToShortDateString());
Console.WriteLine("Due Date: " + dueDate.ToShortDateString());
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
        public static void SortAlpha(Book[] books){
            for(int i=0; i<books.Length-1; i++){
                int min=i;
                for(int x=i+1; x<books.Length;x++){
                    
if(AlphNumVal(books[min].Title)<AlphNumVal(books[x].Title)){
    min=x;
    (books[min], books[i])=(books[i], books[min]);
            }
                }
        }
        for(int i=0; i<books.Length; i++){
            Console.WriteLine(books[i]);
        }
    Console.WriteLine("Book not found");
}
}
        public static double AlphNumVal(string title){
            double val=0;
            for(int i=0; i< title.Length; i++){
                double ex=Double.Parse(i);
if(title[i]='A'||title[i]='a'){
    val+=26/pow(100,ex);
            } else if(title[i]='B'||title[i]='b'){
    val+=25/pow(100,ex);
            } else if(title[i]='C'||title[i]='c'){
    val+=24/pow(100,ex);
            } else if(title[i]='D'||title[i]='d'){
    val+=23/pow(100,ex);
            } else if(title[i]='E'||title[i]='e'){
    val+=22/pow(100,ex);
            } else if(title[i]='F'||title[i]='f'){
    val+=21/pow(100,ex);
            } else if(title[i]='G'||title[i]='g'){
    val+=20/pow(100,ex);
            } else if(title[i]='H'||title[i]='h'){
    val+=19/pow(100,ex);
            } else if(title[i]='I'||title[i]='i'){
    val+=18/pow(100,ex);
            } else if(title[i]='J'||title[i]='j'){
    val+=17/pow(100,ex);
            } else if(title[i]='K'||title[i]='k'){
    val+=16/pow(100,ex);
            } else if(title[i]='L'||title[i]='l'){
    val+=15/pow(100,ex);
            } else if(title[i]='M'||title[i]='m'){
    val+=14/pow(100,ex);
            } else if(title[i]='N'||title[i]='n'){
    val+=13/pow(100,ex);
            } else if(title[i]='O'||title[i]='o'){
    val+=12/pow(100,ex);
            } else if(title[i]='P'||title[i]='p'){
    val+=11/pow(100,ex);
            } else if(title[i]='Q'||title[i]='q'){
    val+=10/pow(100,ex);
            } else if(title[i]='R'||title[i]='r'){
    val+=9/pow(100,ex);
            } else if(title[i]='S'||title[i]='s'){
    val+=8/pow(100,ex);
            } else if(title[i]='T'||title[i]='t'){
    val+=7/pow(100,ex);
            } else if(title[i]='U'||title[i]='u'){
    val+=6/pow(100,ex);
            } else if(title[i]='V'||title[i]='v'){
    val+=5/pow(100,ex);
            } else if(title[i]='W'||title[i]='w'){
    val+=4/pow(100,ex);
            } else if(title[i]='X'||title[i]='x'){
    val+=3/pow(100,ex);
            } else if(title[i]='Y'||title[i]='y'){
    val+=2/pow(100,ex);
            } else if(title[i]='Z'||title[i]='z'){
    val+=1/pow(100,ex);
            } else {
    val+=0;
}
        }
            return val;
        }
}
