using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarEstudiantesConCursoTerminadoUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesConCursoTerminadoUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public List<Dato> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesConCursoTerminado();
    }
}