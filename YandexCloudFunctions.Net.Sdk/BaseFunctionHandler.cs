using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Yandex.Cloud.Functions;

namespace YandexCloudFunctions.Net.Sdk;

public abstract class BaseFunctionHandler(Delegate asyncHandler)
    : YcFunction<FunctionHandlerRequest, FunctionHandlerResponse>
{
    public FunctionHandlerResponse FunctionHandler(FunctionHandlerRequest request, Context context)
    {
        try
        {
            Console.Out.WriteLine($"Received request: {System.Text.Json.JsonSerializer.Serialize(request)}");
            var services = new ServiceCollection();
            services
                .AddLogging(b => b
                    .AddSimpleConsole(c => c.SingleLine = true))
                .AddSingleton(request)
                .AddSingleton(context);
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var handleMethodInfo = asyncHandler.Method;
            if (handleMethodInfo.ReturnType != typeof(Task<FunctionHandlerResponse>))
                throw new Exception("HandleAsync should return Task<FunctionHandlerResponse>");

            var result = handleMethodInfo
                .Invoke(
                    this,
                    handleMethodInfo
                        .GetParameters()
                        .Select(p => serviceProvider.GetRequiredService(p.ParameterType))
                        .ToArray());

            if (result is not Task<FunctionHandlerResponse> task)
                throw new Exception("HandleAsync should return Task<FunctionHandlerResponse>");

            var response = task.GetAwaiter().GetResult();
            return response;
        }
        catch (Exception e)
        {
            Console
                .Error
                .WriteLine($"Exception occurred: {e.Message}, StackTrace: {e.StackTrace}");
            return FunctionHandlerResponses.Fail();
        }
    }

    protected virtual void ConfigureServices(IServiceCollection serviceCollection)
    {
    }
}