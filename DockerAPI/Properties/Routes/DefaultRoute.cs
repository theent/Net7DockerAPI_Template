namespace Routes;

public static class DefaultRoute
{
    public static Task GenerateRoutes(WebApplication app) 
    {
        app.MapGroup("/v1")
        .MapV1Endpoints()
        .WithTags("Public");
        return Task.CompletedTask;
    }


}