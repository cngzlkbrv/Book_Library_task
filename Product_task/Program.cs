namespace Product_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Book book1 = new Book("Sefillerin macerasi","Filankes",100,10);
            Book book2 = new Book("Sefillerin olumu", "Filankesli", 50, 5);
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AllBooks();
            library.GetBook(1);
        }
    }
}
