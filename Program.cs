using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RpgCampanhas.Data;
using RpgCampanhas.Filter;
using RpgCampanhas.Repositories;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services;
using RpgCampanhas.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//builder.WebHost.UseUrls("https://localhost:7154", "http://192.168.1.10:85");

// Add services to the container.

builder.Services.AddControllers();

// Configurar o contexto do banco de dados.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ICampanhaRepository, CampanhaRepository>();
builder.Services.AddScoped<IPersonagemRepository, PersonagemRepository>();
builder.Services.AddScoped<IFicha3detRepository, Ficha3detRepository>();
builder.Services.AddScoped<IGenericRepository, GenericRepository>();
builder.Services.AddScoped<IHistoriaRepository, HistoriaRepository>();
builder.Services.AddScoped<INpcRepository, NpcRepository>();
builder.Services.AddScoped<ILocalRepository, LocalRepository>();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ICampanhaService, CampanhaService>();
builder.Services.AddScoped<IPersonagemService, PersonagemService>();
builder.Services.AddScoped<IFicha3detService, Ficha3detService>();
builder.Services.AddScoped<IFileStorageService, FileStorageService>();
builder.Services.AddScoped<IHistoriaService, HistoriaService>();
builder.Services.AddScoped<INpcService, NpcService>();
builder.Services.AddScoped<ILocalService, LocalService>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "RpgCampanhas API",
        Version = "v1",
        Description = "API para gerenciamento de campanhas de RPG",
        Contact = new OpenApiContact
        {
            Name = "Carlos",
            Email = "seuemail@exemplo.com",
            Url = new Uri("https://seusite.com")
        }
    });
});



builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RpgCampanhas API v1"));
//}

app.UseCors();

app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
