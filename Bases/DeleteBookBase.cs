using Microsoft.AspNetCore.Components;
namespace client.Bases;
public class BookDeleteBase : ComponentBase
{
    [Inject]
    public IBookService bookService { get; set; }

    [Inject]
    public NavigationManager navigationManager { get; set; }

    [Parameter]
    public string id { get; set; }

    public async Task delete()
    {
        await bookService.DeleteBook(int.Parse(id));
        navigationManager.NavigateTo("/booklist");
    }
}