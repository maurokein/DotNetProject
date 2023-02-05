using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarEstudiantesPorCursoUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesPorCursoUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public List<Estudiante> Ejecutar(int cursoId)
    {
        return _rEstudiante.GetEstudiantesPorCurso(cursoId);
    }
}