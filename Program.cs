var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Minimal API with GitHub Action !!!");

app.Run();
