public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }

    public List<Book> GetBooksByAuthor(string author)
    {
        // TODO step 3.
        return [];
    }

    public Book GetBookByTitle(string title)
    {
        // TODO step 3.
        return new Book();
    }

    public Book GetBookByArticul(string articul)
    {
        // TODO step 3.
        return new Book();
    }
}