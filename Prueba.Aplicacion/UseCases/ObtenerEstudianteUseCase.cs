using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ObtenerEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ObtenerEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public Estudiante? Ejecutar(int id)
    {
        return _rEstudiante.GetEstudiante(id);
    }

    public Estudiante? Ejecutar(int dni, string apellido)
    {
        return _rEstudiante.GetEstudiante(dni, apellido);
    }
}