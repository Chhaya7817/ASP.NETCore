using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;


namespace ToDoList.Services
{
    public class TodoService : ITodoService
    {
        private List<ToDoItem> _todoItems;

        public TodoService() 
        {

            _todoItems = new List<ToDoItem>
            {
                new ToDoItem{Id=1, Title="Market", IsCompleted=false},
                new ToDoItem{Id=2,Title="Gardening", IsCompleted=false},
                new ToDoItem{Id=3,Title="Visit Tample", IsCompleted=false},
            };
        }

        public async Task<List<ToDoItem>> GetToDoItemsAsync()
        {
            return await Task.FromResult(this._todoItems);
        }

        public async Task AddTodoItemsAsync(ToDoItem todoItem)
        {
            todoItem.Id=_todoItems.Count+1;
            _todoItems.Add(todoItem);
            await Task.CompletedTask;
        }

        public async Task ToggleToDoItemAsync(ToDoItem toDoItem)
        {
            toDoItem.IsCompleted = !toDoItem.IsCompleted;
            await Task.CompletedTask;
        }
    }
}
