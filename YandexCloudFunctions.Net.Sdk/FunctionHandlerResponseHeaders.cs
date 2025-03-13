using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk;

public class FunctionHandlerResponseHeaders(string contentType = "application/json")
{
    [JsonPropertyName("Content-Type")]
    public string ContentType { get; set; } = contentType;

    [JsonPropertyName("Location")]
    public string? Location { get; set; }
}