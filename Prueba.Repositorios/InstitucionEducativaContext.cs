using Microsoft.EntityFrameworkCore;

using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Repositorios;

public class InstitucionEducativaContext : DbContext
{
    #nullable disable
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable restore 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=InstitucionEducativa.sqlite");
    }
}