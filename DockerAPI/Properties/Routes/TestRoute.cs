using Microsoft.AspNetCore.Http.HttpResults;

namespace Routes;


internal record Person(int Id, string Name);

public static class TestRoute
{
    public static RouteGroupBuilder MapV1Endpoints(this RouteGroupBuilder group)
    {
        group.MapGet("/", DefaultGet);
        group.MapGet("/testString", TestStringGet);
        return group;
    }


    private static async Task<Ok<Person>> DefaultGet()
    {
        await Task.Yield();
        return TypedResults.Ok(new Person(1, "john"));
    }

    private static async Task<Ok<string>> TestStringGet()
    {
        await Task.Yield();
        string testString = TestFunctions.TestFunctions.TestString();
        return TypedResults.Ok(testString);
    }


}