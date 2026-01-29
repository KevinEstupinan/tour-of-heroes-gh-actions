var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var hero = new Hero
    {
        Id = 1,
        Name = "Windstorm"
    };

    return Results.Ok(hero);
});

app.Run();


public class Hero
{
    public int Id { get; set; }
    public required string Name { get; set; }
}
