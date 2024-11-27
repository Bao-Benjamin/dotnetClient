using client.DTO;

public interface IBookService
{
    Task<Book> AddBook(Book book);
    Task<IEnumerable<Book>> GetAllBook();
    Task<Book> GetBook(int id);

    Task DeleteBook(int id);
    
    Task<Book> UpdateBook( Book book);
}