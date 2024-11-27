using client.DTO;
using Microsoft.AspNetCore.Components;
namespace client.Bases;
public class AddBookBase : ComponentBase
{
    public Book book = new Book();

    [Inject]
    public IBookService bookService {get;set;}

     [Inject]
    public NavigationManager navigationManager { get; set; }
     public async Task submit()
    {
        var rs = await bookService.AddBook(book);
        if (rs != null)
        {
            navigationManager.NavigateTo("/booklist");
        }
        else
        {
            Console.WriteLine(rs);
        }
    }
}