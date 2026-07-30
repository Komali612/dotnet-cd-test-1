namespace DotnetService;

public class GreetingService
{
    public const string DefaultName = "world";

    public string Greet(string? name)
    {
        var target = string.IsNullOrWhiteSpace(name) ? DefaultName : name.Trim();
        return $"Hello, {target}!";
    }
}
