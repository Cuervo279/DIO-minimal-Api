var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalAPi.DTO.LoginDTO logindto) =>
{
    if (logindto.Email == "adm@teste.com" && logindto.Senha == "123456")
    {
        return Results.Ok("Login successful");
    }
    else
    {
        return Results.Unauthorized();
    }
});


app.Run();

public class LoginDTO
{
    public string Email { get; set; }
    public string Senha { get; set; }
}