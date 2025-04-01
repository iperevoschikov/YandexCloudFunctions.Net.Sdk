namespace YandexCloudFunctions.Net.Sdk.MessageQueue;

public class QueueTriggerRequest
{
    public QueueMessageEvent[] messages { get; set; } = null!;
}