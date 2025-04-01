using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk.MessageQueue;

public class QueueMessageEventMessage(string body)
{
    [JsonPropertyName("body")]
    public string Body { get; init; } = body;
}