using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk.MessageQueue;

public class QueueMessageEvent(QueueMessageEventDetails details)
{
    [JsonPropertyName("details")]
    public QueueMessageEventDetails Details { get; init; } = details;
}