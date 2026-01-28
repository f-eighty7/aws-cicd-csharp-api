using RovarApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<RovarTranslator>();

var app = builder.Build();

app.MapGet("/", () => "Välkommen till Rövar-API!");

// Endpoint 1: Kryptera
app.MapGet("/encrypt", (string text, RovarTranslator translator) =>
{
    return translator.ToRovarsprak(text);
});

// Endpoint 2: Avkryptera
app.MapGet("/decrypt", (string text, RovarTranslator translator) =>
{
    return translator.FromRovarsprak(text);
});

app.Run();