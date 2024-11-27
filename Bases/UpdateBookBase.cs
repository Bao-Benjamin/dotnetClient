using System.Configuration;
using client.DTO;
using Microsoft.AspNetCore.Components;
namespace client.Bases;
public class UpdateBookBase : ComponentBase
{
    public Book book { get; set; } = new Book();

    [Inject]
    public IBookService bookService { get; set; }

    [Inject]
    public NavigationManager manager { get; set; }

    [Parameter]
    public string id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        book = await bookService.GetBook(int.Parse(id));
    }

    public async Task update()
    {
        Console.WriteLine($"{book.Id} and {book.Name} and {book.Price}");
        await handleUpdate(book);
    }

    public async Task handleUpdate(Book book)
    {
        await bookService.UpdateBook(book);
        manager.NavigateTo("/booklist");
    }
}