using ToDoList.Services;

namespace ToDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var builder = MauiApp.CreateBuilder();
            builder.Services.AddScoped<ITodoService, TodoService>();
            var app=builder.Build();
            app.Services.GetService<ITodoService>();
            MainPage = new AppShell();
        }

       
    }
}
