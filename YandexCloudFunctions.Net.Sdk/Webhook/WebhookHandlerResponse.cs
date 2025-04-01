using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk.Webhook;

public class WebhookHandlerResponse(
    int statusCode,
    string? body,
    WebhookHandlerResponseHeaders headers,
    bool isBase64Encoded = false)
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; } = statusCode;

    [JsonPropertyName("body")]
    public string? Body { get; set; } = body;

    [JsonPropertyName("headers")]
    public WebhookHandlerResponseHeaders Headers { get; set; } = headers;

    [JsonPropertyName("isBase64Encoded")]
    public bool IsBase64Encoded { get; set; } = isBase64Encoded;
}