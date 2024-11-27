using System.Runtime.InteropServices;
using client.DTO;
using Microsoft.AspNetCore.Components;
namespace client.Bases;
public class BookListBase : ComponentBase
{
    [Inject]
    public IBookService BookService { get; set; }

    public IEnumerable<Book> books { get; set; }

    protected override async Task OnInitializedAsync()
    {
        books = await BookService.GetAllBook();
    }


}