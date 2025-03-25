// ReSharper disable InconsistentNaming

#pragma warning disable CS8618

namespace YandexCloudFunctions.Net.Sdk;

// ReSharper disable once ClassNeverInstantiated.Global
public class FunctionHandlerRequest
{
    public string httpMethod { get; set; }

    public string body { get; set; }

    public Dictionary<string, string> queryStringParameters { get; set; }
}