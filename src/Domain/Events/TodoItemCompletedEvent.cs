using Suggestify.Domain.Common;
using Suggestify.Domain.Entities;

namespace Suggestify.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
