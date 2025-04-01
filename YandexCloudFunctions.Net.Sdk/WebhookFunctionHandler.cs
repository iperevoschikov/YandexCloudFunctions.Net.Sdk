using YandexCloudFunctions.Net.Sdk.Webhook;

namespace YandexCloudFunctions.Net.Sdk;

public class WebhookFunctionHandler(Delegate asyncHandler)
    : BaseFunctionHandler<WebhookHandlerRequest, WebhookHandlerResponse>(asyncHandler)
{
    protected override WebhookHandlerResponse CreateFailResponse(Exception exception) => WebhookHandlerResponses.Fail();
}