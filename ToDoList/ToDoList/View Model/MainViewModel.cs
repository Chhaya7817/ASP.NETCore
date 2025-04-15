using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Services;
using ToDoList.Models;

namespace ToDoList.View_Model
{
    public class MainViewModel
    {
        private readonly ITodoService _todoService;
        public ObservableCollection<ToDoItem> TodoItems { get; }=new ObservableCollection<ToDoItem>();
        
        public MainViewModel(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task LoadToDoItemsAsync()
        {
            var todoItems= await _todoService.GetToDoItemsAsync();
            foreach (var item in todoItems)
            {
                TodoItems.Add(item);
            }
        }
        public async Task AddToDoItemsAsync(string title)
        {
            var newTodoItem = new ToDoItem { Title = title };
            await _todoService.AddTodoItemsAsync(newTodoItem);
            TodoItems.Add(newTodoItem);

        }

        public async Task ToggleToDoItemAsync(ToDoItem toDoItem)
        {
            await _todoService.ToggleToDoItemAsync(toDoItem);
        }



    }
}
