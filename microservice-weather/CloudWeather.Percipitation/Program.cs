var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();
app.MapGet("/observation/{zip}", (string zip) =>
{
    return Results.Ok(zip);
});
app.Run();
