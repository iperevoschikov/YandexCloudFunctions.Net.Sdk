namespace YandexCloudFunctions.Net.Sdk;

public static class FunctionHandlerResponses
{
    public static FunctionHandlerResponse Ok(string? body = null)
    {
        return new FunctionHandlerResponse(200, body, new FunctionHandlerResponseHeaders());
    }

    public static FunctionHandlerResponse Redirect(string location)
    {
        return new FunctionHandlerResponse(
            302,
            null,
            new FunctionHandlerResponseHeaders
            {
                Location = location
            });
    }

    public static FunctionHandlerResponse BadRequest()
    {
        return new FunctionHandlerResponse(400, null, new FunctionHandlerResponseHeaders());
    }

    public static FunctionHandlerResponse NotFound()
    {
        return new FunctionHandlerResponse(404, null, new FunctionHandlerResponseHeaders());
    }

    public static FunctionHandlerResponse Fail(string? error = null)
    {
        return new FunctionHandlerResponse(500, error, new FunctionHandlerResponseHeaders());
    }
}