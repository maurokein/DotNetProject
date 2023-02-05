using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Prueba.UI.Data;
using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;
using Prueba.Aplicacion.UseCases;
using Prueba.Repositorios;

using (var context = new InstitucionEducativaContext())
{
    context.Database.EnsureCreated();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<AgregarCursoUseCase>();
builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<AgregarInscripcionUseCase>();
builder.Services.AddTransient<EliminarCursoUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<EliminarInscripcionUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddTransient<ObtenerCursoUseCase>();
builder.Services.AddTransient<ObtenerEstudianteUseCase>();
builder.Services.AddTransient<ObtenerInscripcionUseCase>();
builder.Services.AddTransient<ListarEstudiantesUseCase>();
builder.Services.AddTransient<ListarEstudiantesConCursoEnProcesoUseCase>();
builder.Services.AddTransient<ListarEstudiantesConCursoTerminadoUseCase>();
builder.Services.AddTransient<ListarEstudiantesPorCursoUseCase>();
builder.Services.AddTransient<ListarCursosPorEstudianteUseCase>();
builder.Services.AddTransient<ListarCursosUseCase>();
builder.Services.AddTransient<ListarInscripcionesUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();

builder.Services.AddScoped<IRepositorioEstudiante, RepositorioEstudiante>();
builder.Services.AddScoped<IRepositorioCurso, RepositorioCurso>();
builder.Services.AddScoped<IRepositorioInscripcion, RepositorioInscripcion>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
