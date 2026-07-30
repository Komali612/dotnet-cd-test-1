using DotnetService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<GreetingService>();

var app = builder.Build();

app.MapGet("/greeting", (string? name, GreetingService greetings) =>
    Results.Ok(new GreetingResponse(greetings.Greet(name))));

app.Run();

public record GreetingResponse(string Message);

// Exposes the implicit Program class to WebApplicationFactory in the test project.
public partial class Program
{
}
