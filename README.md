# YandexCloudFunctions.Net.Sdk
My boilerplate code for work with Yandex Cloud Functions

To create new function just inherit from `BaseFunctionHandler` and implement `HandleAsync` method which returns `Task<FunctionHandlerResponse>`