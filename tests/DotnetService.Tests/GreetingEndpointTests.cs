using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace DotnetService.Tests;

public class GreetingEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public GreetingEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GreetingEndpointReturnsMessage()
    {
        var response = await _client.GetFromJsonAsync<GreetingResponse>("/greeting?name=Komali");
        Assert.NotNull(response);
        Assert.Equal("Hello, Komali!", response!.Message);
    }

    [Fact]
    public async Task GreetingEndpointDefaults()
    {
        var response = await _client.GetFromJsonAsync<GreetingResponse>("/greeting");
        Assert.NotNull(response);
        Assert.Equal("Hello, world!", response!.Message);
    }
}
