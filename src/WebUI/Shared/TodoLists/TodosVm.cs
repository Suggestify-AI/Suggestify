using Suggestify.WebUI.Shared.Common;

namespace Suggestify.WebUI.Shared.TodoLists;

public class TodosVm
{
    public List<LookupDto> PriorityLevels { get; set; } = new();

    public List<TodoListDto> Lists { get; set; } = new();
}
