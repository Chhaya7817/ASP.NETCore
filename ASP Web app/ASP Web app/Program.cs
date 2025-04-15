var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Hi There, How are you");
    await next(context);
    await context.Response.WriteAsync("Hyes let me go now");
});

app.Use(async (check, next) =>
{
    await check.Response.WriteAsync("\nHey I am Fine\n");
    await next(check);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hey again\n");
    
});
app.Run();
