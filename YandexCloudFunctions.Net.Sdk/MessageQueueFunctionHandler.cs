using YandexCloudFunctions.Net.Sdk.MessageQueue;

namespace YandexCloudFunctions.Net.Sdk;

public class MessageQueueFunctionHandler(Delegate asyncHandler)
    : BaseFunctionHandler<QueueTriggerRequest, string>(asyncHandler)
{
    protected override string CreateFailResponse(Exception exception) => string.Empty;
}