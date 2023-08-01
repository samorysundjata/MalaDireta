using MalaDireta.Context;
using MalaDireta.Extensions;
using System.Text.Json.Serialization;

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


//builder.Services.AddControllers().AddJsonOptions(options =>
//    options.JsonSerializerOptions.ReferenceHandler
//        = ReferenceHandler.IgnoreCycles);
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<AppDbContext>();



// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();


//

//
//

//var app = builder.Build();

//


