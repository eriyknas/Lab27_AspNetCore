var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-231! Автор: Настя и Полина");

app.Run();
