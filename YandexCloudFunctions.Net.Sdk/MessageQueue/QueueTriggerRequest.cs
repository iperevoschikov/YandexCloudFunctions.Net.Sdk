using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk.MessageQueue;

public class QueueTriggerRequest
{
    [JsonPropertyName("messages")]
    public QueueMessageEvent[] Messages { get; set; } = null!;
}