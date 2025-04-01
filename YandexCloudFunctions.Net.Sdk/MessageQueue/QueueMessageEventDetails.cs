namespace YandexCloudFunctions.Net.Sdk.MessageQueue;

public class QueueMessageEventDetails
{
    public string queue_id { get; set; }

    public QueueMessageEventMessage message { get; set; }
}