
using client.DTO;
using Microsoft.AspNetCore.Components;
namespace client.Bases;
public class BookDetailsBase : ComponentBase
{
    public Book book { get; set; } = new Book();

    [Inject]
    public IBookService bookService { get; set; }

    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        book = await bookService.GetBook(int.Parse(Id));
    }

}