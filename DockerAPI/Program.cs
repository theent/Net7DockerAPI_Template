using Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

await DefaultRoute.GenerateRoutes(app);

// app.MapGet("/", () => "Hello World!");

app.Run();
