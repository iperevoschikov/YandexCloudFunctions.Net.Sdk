namespace YandexCloudFunctions.Net.Sdk.Webhook;

public static class WebhookHandlerResponses
{
    public static WebhookHandlerResponse Ok(string? body = null)
    {
        return new WebhookHandlerResponse(200, body, new WebhookHandlerResponseHeaders());
    }

    public static WebhookHandlerResponse Redirect(string location)
    {
        return new WebhookHandlerResponse(
            302,
            null,
            new WebhookHandlerResponseHeaders
            {
                Location = location
            });
    }

    public static WebhookHandlerResponse BadRequest()
    {
        return new WebhookHandlerResponse(400, null, new WebhookHandlerResponseHeaders());
    }

    public static WebhookHandlerResponse NotFound()
    {
        return new WebhookHandlerResponse(404, null, new WebhookHandlerResponseHeaders());
    }

    public static WebhookHandlerResponse Fail(string? error = null)
    {
        return new WebhookHandlerResponse(500, error, new WebhookHandlerResponseHeaders());
    }
}