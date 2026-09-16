using BalnearioPinhalShowcase.Dados;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => policy.AllowAnyOrigin());
});

var app = builder.Build();

app.UseCors();
app.UseDefaultFiles();   // serve wwwroot/index.html em "/"
app.UseStaticFiles();    // serve css/js/img de wwwroot

// ---- API do mostruário -----------------------------------------------
// Cada endpoint devolve um recorte dos dados da cidade para o front-end
// montar as seções dinamicamente (fetch + render em app.js).

var api = app.MapGroup("/api");

api.MapGet("/ficha", () => AcervoCidade.Ficha)
   .WithName("ObterFichaTecnica");

api.MapGet("/numeros", () => AcervoCidade.Numeros)
   .WithName("ObterNumeros");

api.MapGet("/pontos-turisticos", () => AcervoCidade.PontosTuristicos)
   .WithName("ObterPontosTuristicos");

api.MapGet("/curiosidades", () => AcervoCidade.Curiosidades)
   .WithName("ObterCuriosidades");

api.MapGet("/distritos", () => AcervoCidade.Distritos)
   .WithName("ObterDistritos");

app.Run();
