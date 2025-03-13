using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk;

public class FunctionHandlerResponse(
    int statusCode,
    string? body,
    FunctionHandlerResponseHeaders headers,
    bool isBase64Encoded = false)
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; } = statusCode;

    [JsonPropertyName("body")]
    public string? Body { get; set; } = body;

    [JsonPropertyName("headers")]
    public FunctionHandlerResponseHeaders Headers { get; set; } = headers;

    [JsonPropertyName("isBase64Encoded")]
    public bool IsBase64Encoded { get; set; } = isBase64Encoded;
}