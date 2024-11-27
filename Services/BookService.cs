using client.DTO;

public class BookService : IBookService
{
    private readonly HttpClient http;
    public BookService(HttpClient http){
        this.http=http;
    }

    public async Task<Book> AddBook(Book book)
    {
       var rs = await http.PostAsJsonAsync<Book>("api/book",book);
       rs.EnsureSuccessStatusCode();
       return await rs.Content.ReadFromJsonAsync<Book>();
    }

    public async Task DeleteBook(int id)
    {
        await http.DeleteAsync($"api/book/{id}");
    }

    public async Task<IEnumerable<Book>> GetAllBook()
    {
        return await http.GetFromJsonAsync<Book[]>("api/book");
    }

    public async Task<Book> GetBook(int id)
    {
        return await http.GetFromJsonAsync<Book>($"api/book/{id}");
    }

    public async Task<Book> UpdateBook( Book book)
    {  
        var res = await http.PutAsJsonAsync($"api/book", book);
        res.EnsureSuccessStatusCode();
        return await res.Content.ReadFromJsonAsync<Book>();
    }

  
}