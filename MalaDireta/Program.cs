using MalaDireta.Context;
using MalaDireta.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddCors();
builder.AddApiSwagger();
builder.AddPersistence();
builder.AddAutenticationJwt();

var app = builder.Build();

app.MapAutenticacaoEndpoints();

var environment = app.Environment;
app.UseExceptionHandling(environment)
    .UseSwaggerMiddleware()
    .UseAppCors();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

