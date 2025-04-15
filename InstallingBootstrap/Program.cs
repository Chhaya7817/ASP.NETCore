var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); 
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    //pattern:"Programentor/{controller=Home}/{action=Index}/{id?}"
    pattern: "{controller=Home}/{action=Form}/{id?}"
    );
app.Run();
