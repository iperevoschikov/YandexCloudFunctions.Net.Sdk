using System.Text.Json.Serialization;

namespace YandexCloudFunctions.Net.Sdk.MessageQueue;

public class QueueMessageEventDetails(string queueId, QueueMessageEventMessage message)
{
    [JsonPropertyName("queue_id")]
    public string QueueId { get; init; } = queueId;

    [JsonPropertyName("message")]
    public QueueMessageEventMessage Message { get; init; } = message;
}