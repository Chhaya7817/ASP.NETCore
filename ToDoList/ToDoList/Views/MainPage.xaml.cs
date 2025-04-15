using Microsoft.Maui.Controls;
using ToDoList.Models;
using ToDoList.Services;
using ToDoList.View_Model;


namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new TodoService());
            BindingContext = _viewModel;

        }

        private async void OnAddTodoClicked(object sender, EventArgs e)
        {
            var newTodoTitle = NewTodoEntry.Text;
            if (!String.IsNullOrWhiteSpace(newTodoTitle))
            {
                await _viewModel.AddToDoItemsAsync(newTodoTitle);
                NewTodoEntry.Text = string.Empty;
            }
        }

        private async void OnTodoItemToggled(object sender, ToggledEventArgs e)
        {
            if (sender is Switch toggleSwitch && toggleSwitch.BindingContext is ToDoItem todoItem)
            {
                await _viewModel.ToggleToDoItemAsync(todoItem);
            }
        }


    }
}
