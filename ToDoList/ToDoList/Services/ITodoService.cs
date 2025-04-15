using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public interface ITodoService
    {
        Task<List<ToDoItem>> GetToDoItemsAsync();
        Task AddTodoItemsAsync(ToDoItem todoItem);
        Task ToggleToDoItemAsync(ToDoItem todoItem);
    }
}
