using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Register controllers (required for app.MapControllers())
builder.Services.AddControllers();

// Adiciona o OpenAPI nativo do .NET (sem Swagger)
builder.Services.AddOpenApi();

var app = builder.Build();

// Expõe o documento OpenAPI
app.MapOpenApi();

// 👉 Adicione o Scalar aqui:
app.MapScalarApiReference(options =>
{
    options.Title = "Minha API .NET 10";
    options.Theme = ScalarTheme.Moon;
});

// Seus endpoints da API
app.MapControllers();

app.Run();
