using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk;

public class FunctionHandlerRequest(
    string httpMethod,
    string body,
    Dictionary<string, string> queryStringParameters)
{
    [JsonPropertyName("httpMethod")]
    public string HttpMethod { get; init; } = httpMethod;

    [JsonPropertyName("body")]
    public string Body { get; init; } = body;

    [JsonPropertyName("queryStringParameters")]
    public Dictionary<string, string> QueryStringParameters { get; init; } = queryStringParameters;
}